using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangerUniversity
{
    public partial class frmManageSubject : Form
    {
        Khoa currentKhoa;
        Major currentMajor;
        List<Subject> subjects;
        Subject currentSubject;
        bool currentInscrease = true;
        public frmManageSubject()
        {
            InitializeComponent();
            ImageList img = new ImageList();
            img.Images.Add(Image.FromFile("Assets/Imgs/Select.png"));
            img.Images.Add(Image.FromFile("Assets/Imgs/Khoa.png"));
            img.Images.Add(Image.FromFile("Assets/Imgs/Major.png"));
            img.Images.Add(Image.FromFile("Assets/Imgs/Class.png"));
            tvKhoa.ImageList = img;
            txtSoTC.KeyPress += General.number_KeyPress;
            txtSoTiet.KeyPress += General.number_KeyPress;
            loadKhoaNganh();
            cbbHocKi.SelectedIndex = 0;
            cbbYear.SelectedIndex = 0;
        }

        void loadKhoaNganh()
        {
            tvKhoa.Nodes.Clear();
            TreeNode root = new TreeNode()
            {
                Text = "Khoa / Viện",
                Tag = "0",
                ImageIndex = 0,
            };
            List<Khoa> khoas = Khoa.getAllKhoa();
            for (int i = 0; i < khoas.Count; i++)
            {
                TreeNode nodeKhoa = new TreeNode()
                {
                    Text = khoas[i].getName(),
                    Tag = "1",
                    ImageIndex = 1,
                };
                List<Major> majors = khoas[i].getMyMajor();
                for (int j = 0; j < majors.Count; j++)
                {
                    TreeNode nodeMajor = new TreeNode()
                    {
                        Text = majors[j].getName(),
                        Tag = "2",
                        ImageIndex = 2,
                    };
                    nodeKhoa.Nodes.Add(nodeMajor);
                }
                root.Nodes.Add(nodeKhoa);
            }
            tvKhoa.Nodes.Add(root);
            tvKhoa.ExpandAll();
        }

        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string tag = (string)e.Node.Tag;
            if (tag == "2")
            {
                currentKhoa = new Khoa(e.Node.Parent.Text);
                currentMajor = Major.getInfo(e.Node.Text);
                loadSubject();
                pnSubject.Enabled = true;
            }
            else
            {
                currentMajor = null;
                if (tag == "1")
                {
                    currentKhoa = new Khoa(e.Node.Parent.Text);
                    pnSubject.Enabled = true;
                    loadSubject();
                }
                else
                {
                    currentKhoa = null;
                    lvSubject.Items.Clear();
                    pnSubject.Enabled = false;
                }
            }
        }

        void resetDefault()
        {
            currentSubject = null;
            btnDelete.Enabled = false;
            gbInfo.Enabled = false;
            txtName.Text = "";
        }

        void loadSubject()
        {
            if (currentMajor != null)
            {
                subjects = currentMajor.getMySubjects();
            }
            else
            {
                subjects = currentKhoa.getMySubjects();
            }
            findAndSort();
            uploadList();
        }

        void uploadList()
        {
            if (subjects == null)
            {
                return;
            }
            lvSubject.Items.Clear();
            currentSubject = null;
            gbInfo.Enabled = false;
            btnDelete.Enabled = false;
            for (int i = 0; i < subjects.Count; i++)
            {
                ListViewItem lvi = new ListViewItem()
                {
                    Text = subjects[i].getName(),
                };
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = subjects[i].getMust() == true ? "X" : "" });
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = subjects[i].getSoTC().ToString() });
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = subjects[i].getSoTiet().ToString() });
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = subjects[i].getMoney().ToString() });
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = subjects[i].getHocKi().ToString() });
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = subjects[i].getYear().ToString() });
                lvSubject.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lvSubject.SelectedIndices.Clear();
            gbInfo.Text = "Thêm môn học";
            resetDefault();
            gbInfo.Enabled = true;
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',' && (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar > 30)))
            {
                e.Handled = true;
            }
        }

        void removeListByCharName(char c)
        {
            c = char.ToLower(c);
            for (int i = 0; i < subjects.Count; i++)
            {
                bool remove = !subjects[i].getName().ToLower().Contains(c);
                if (remove)
                {
                    subjects.RemoveAt(i);
                    i--;
                }
            }
        }
        
        void search()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                for (int i = 0; i < txtSearch.Text.Length; i++)
                {
                    removeListByCharName(txtSearch.Text[i]);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            findAndFilter();
            search();
            findAndSort();
            uploadList();
        }

        void sortByHocKiAndYear(bool isIncrease = true)
        {
            bool[] check = new bool[10];
            for (int i =0; i < check.Length; i++)
            {
                check[i] = false;
            }
            List<List<Subject>> lst = new List<List<Subject>>();
            for (int i = 0; i < subjects.Count; i++)
            {
                if (!check[subjects[i].getYear()])
                {
                    check[subjects[i].getYear()] = true;
                    List<Subject> tmp = new List<Subject>();
                    tmp.Add(subjects[i]);
                    for (int j = i + 1; j < subjects.Count; j++)
                    {
                        if (subjects[i].getYear() == subjects[j].getYear())
                        {
                            tmp.Add(subjects[j]);
                        }
                    }
                    lst.Add(tmp);
                }
            }
            for (int i = 0; i < lst.Count - 1; i++)
            {
                for (int j = i + 1; j < lst.Count; j++)
                {
                    if (isIncrease)
                    {
                        if (lst[i][0].getYear() > lst[j][0].getYear())
                        {
                            List<Subject> tmp = lst[i];
                            lst[i] = lst[j];
                            lst[j] = tmp;
                        }
                    }
                    else
                    {
                        if (lst[i][0].getYear() < lst[j][0].getYear())
                        {
                            List<Subject> tmp = lst[i];
                            lst[i] = lst[j];
                            lst[j] = tmp;
                        }
                    }
                }
            }
            for (int i = 0; i < lst.Count; i++)
            {
                for (int j = 0; j < lst[i].Count - 1; j++)
                {
                    for (int k = j + 1; k < lst[i].Count; k++)
                    {
                        if (lst[i][j].getHocKi() > lst[i][k].getHocKi())
                        {
                            Subject sub = lst[i][j].getCoppy();
                            lst[i][j] = lst[i][k].getCoppy();
                            lst[i][k] = sub.getCoppy();
                        }
                    }
                }
            }
            subjects = new List<Subject>();
            for (int i = 0; i < lst.Count; i++)
            {
                for (int j = 0; j < lst[i].Count; j++)
                {
                    subjects.Add(lst[i][j]);
                }
            }
        }

        void sortByName(bool isIncrease = true)
        {
            for (int i = 0; i < subjects.Count - 1; i++)
            {
                for (int j = i + 1; j < subjects.Count; j++)
                {
                    int lengthA = subjects[i].getName().Length;
                    int lengthB = subjects[j].getName().Length;
                    int length = lengthA > lengthB ? lengthB : lengthA;
                    for (int k = 0; k < length; k++)
                    {
                        if (isIncrease)
                        {
                            if (subjects[i].getName()[k] > subjects[j].getName()[k])
                            {
                                Subject subject = subjects[i].getCoppy();
                                subjects[i] = subjects[j].getCoppy();
                                subjects[j] = subject.getCoppy();
                                break;
                            }
                            else if (subjects[i].getName()[k] < subjects[j].getName()[k])
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (subjects[i].getName()[k] < subjects[j].getName()[k])
                            {
                                Subject subject = subjects[i].getCoppy();
                                subjects[i] = subjects[j].getCoppy();
                                subjects[j] = subject.getCoppy();
                                break;
                            }
                            else if (subjects[i].getName()[k] > subjects[j].getName()[k])
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        void sortByMoney(bool isIncrease = true)
        {
            for (int i = 0; i < subjects.Count - 1; i++)
            {
                for (int j = i + 1; j < subjects.Count; j++)
                {
                    if (isIncrease)
                    {
                        if (subjects[i].getMoney() > subjects[j].getMoney())
                        {

                            Subject subject = subjects[i].getCoppy();
                            subjects[i] = subjects[j].getCoppy();
                            subjects[j] = subject.getCoppy();
                            break;
                        }
                        else if (subjects[i].getMoney() < subjects[j].getMoney())
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (subjects[i].getMoney() < subjects[j].getMoney())
                        {

                            Subject subject = subjects[i].getCoppy();
                            subjects[i] = subjects[j].getCoppy();
                            subjects[j] = subject.getCoppy();
                            break;
                        }
                        else if (subjects[i].getMoney() > subjects[j].getMoney())
                        {
                            break;
                        }
                    }
                }
            }
        }
        void findAndSort(RadioButton rdo = null)
        {
            if (rdo != null)
            {
                if (rdo == rdoSortHocKiAndYear)
                {
                    sortByHocKiAndYear(currentInscrease);
                }
                else if (rdo == rdoSortName)
                {
                    sortByName(currentInscrease);
                }
                else
                {
                    sortByMoney(currentInscrease);
                }
            }
            else
            {
                if (rdoSortHocKiAndYear.Checked)
                {
                    sortByHocKiAndYear(currentInscrease);
                }
                else if (rdoSortName.Checked)
                {
                    sortByName(currentInscrease);
                }
                else
                {
                    sortByMoney(currentInscrease);
                }
            }
        }

        private void radio_CheckedTypeSort(object sender, EventArgs e)
        {
            if (rdoInscrease.Checked)
            {
                currentInscrease = true;
            }
            else
            {
                currentInscrease = false;
            }

            findAndFilter();
            search();
            findAndSort();
            uploadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắc muốn xoá các môn đã check không?") != DialogResult.Yes)
            {
                return;
            }
            for (int i = 0; i < lvSubject.CheckedIndices.Count; i++)
            {
                subjects[lvSubject.CheckedIndices[i]].deleteSubject();
            }
            loadSubject();
            resetDefault();
        }

        private void lvSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSubject.SelectedIndices.Count == 0)
            {
                gbInfo.Enabled = false;
                return;
            }
            gbInfo.Enabled = true;
            int index = lvSubject.SelectedIndices[0];
            currentSubject = subjects[index];
            txtName.Text = subjects[index].getName();
            txtSoTC.Text = subjects[index].getSoTC().ToString();
            txtSoTiet.Text = subjects[index].getSoTiet().ToString();
            txtMoney.Text = subjects[index].getMoney().ToString();
            ckMust.Checked = subjects[index].getMust();
            cbbYear.Text = subjects[index].getYear().ToString();
            cbbHocKi.Text = subjects[index].getHocKi().ToString();
        }

        private void lvSubject_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lvSubject.CheckedIndices.Count != 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSoTC.Text) || string.IsNullOrEmpty(txtMoney.Text) || cbbYear.SelectedIndex == -1)
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập đủ thông tin!");
                return;
            }
            if (cbbHocKi.SelectedIndex == -1)
            {
                MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa chọn học kì cho môn học!");
                return;
            }
            Subject subject = new Subject(txtName.Text, ckMust.Checked, int.Parse(txtSoTC.Text), int.Parse(txtSoTiet.Text), double.Parse(txtMoney.Text), int.Parse(cbbHocKi.SelectedItem.ToString()), int.Parse(cbbYear.Text));
            List<Major> majors;
            if (currentMajor == null)
            {
                majors = currentKhoa.getMyMajor();
            }
            else
            {
                majors = new List<Major>() { currentMajor };
            }
            if (currentSubject == null)
            {
                if (subject.addSubject(majors))
                {
                    MessageInfo.makeMessage("Information", "Chúc mừng", "Thêm môn thành công!");
                    loadSubject();
                    resetDefault();
                    gbInfo.Enabled = true;
                    txtName.Focus();
                }
                else
                {

                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Thêm môn thất bại!");
                }
            }
            else
            {
                if (currentSubject.updateSubject(subject, majors))
                {
                    loadSubject();
                    resetDefault();
                }
                else
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Cập nhật thất bại");
                }
            }
        }

        void findAndFilter()
        {
            if (currentMajor != null)
            {
                subjects = currentMajor.getMySubjects();
            }
            else
            {
                subjects = currentKhoa.getMySubjects();
            }
            if (rdoFilterMust.Checked)
            {
                for (int i = 0; i < subjects.Count; i++)
                {
                    if (!subjects[i].getMust())
                    {
                        subjects.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (rdoFilterNotMust.Checked)
            {
                for (int i = 0; i < subjects.Count; i++)
                {
                    if (subjects[i].getMust())
                    {
                        subjects.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private void rdo_CheckedChangeFilter(object sender, EventArgs e)
        {
            findAndFilter();
            search();
            findAndSort();
            uploadList();
        }

        private void rdoSortBy_CheckedChanged(object sender, EventArgs e)
        {
            findAndFilter();
            search();
            findAndSort();
            uploadList();
        }
    }
}
