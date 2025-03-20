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
    public partial class frmManageKhoa : Form
    {
        TreeNode currentNode;
        public frmManageKhoa()
        {
            InitializeComponent();
            ImageList img = new ImageList();
            img.Images.Add(Image.FromFile("Assets/Imgs/Select.png"));
            img.Images.Add(Image.FromFile("Assets/Imgs/Khoa.png"));
            img.Images.Add(Image.FromFile("Assets/Imgs/Major.png"));
            img.Images.Add(Image.FromFile("Assets/Imgs/Class.png"));
            txtCountYear.KeyPress += General.number_KeyPress;
            txtCountMax.KeyPress += General.number_KeyPress;
            tvKhoa.ImageList = img;
            uploadInfo();
            if (currentNode == null)
            {
                NoSelected();
            }
        } 

        void NoSelected()
        {
            gbInfo.Enabled = false;
            btnAccept.Enabled = false;
            btnDelete.Enabled = false;
            clearText();
            tvKhoa.SelectedNode = null;
            currentNode = null;
        }

        void uploadInfo(string currenTextNode = null)
        {
            tvKhoa.Nodes.Clear();
            TreeNode root = new TreeNode()
            {
                Text = "Khoa / Viện",
                Tag = "0",
                ImageIndex = 0,
            };
            DataTable dataKhoa = SQL.Excute_Values("Select * from Khoa", null, null);
            if (dataKhoa == null)
            {
                return;
            }
            for (int i = 0; i < dataKhoa.Rows.Count;i++)
            {
                TreeNode nodeKhoa = new TreeNode()
                {
                    Text = (string)dataKhoa.Rows[i][0],
                    Tag = "1",
                    ImageIndex = 1,
                };
                DataTable dataMajor = SQL.Excute_Values("Select * from Nganh where TenKhoa = @TenKhoa", new List<string>() { "TenKhoa" }, new List<object>() { nodeKhoa.Text });
                if (dataMajor != null)
                {
                    for (int j = 0; j < dataMajor.Rows.Count; j++)
                    {
                        TreeNode nodeMajor = new TreeNode()
                        {
                            Text = (string)dataMajor.Rows[j][0],
                            Tag = "2",
                            ImageIndex = 2,
                        }; ;
                        DataTable dataSubject = SQL.Excute_Values("Select * from Lop where TenNganh = @TenNganh", new List<string>() { "TenNganh" }, new List<object>() { nodeMajor.Text });
                        if (dataSubject != null)
                        {
                            for (int k = 0; k < dataSubject.Rows.Count; k ++)
                            {
                                TreeNode nodeSubject = new TreeNode()
                                {
                                    Text = (string)dataSubject.Rows[k][0],
                                    Tag = "3",
                                    ImageIndex = 3,
                                };
                                if (nodeSubject.Text == currenTextNode)
                                {
                                    currentNode = nodeSubject;
                                }
                                nodeMajor.Nodes.Add(nodeSubject);
                            }
                        }
                        if (nodeMajor.Text == currenTextNode)
                        {
                            currentNode = nodeMajor;
                        }
                        nodeKhoa.Nodes.Add(nodeMajor);
                    }
                }
                if (nodeKhoa.Text == currenTextNode)
                {
                    currentNode = nodeKhoa;
                }
                root.Nodes.Add(nodeKhoa);
            }
            tvKhoa.Nodes.Add(root);
            tvKhoa.ExpandAll();
            NoSelected();
        }
        

        void clearText()
        {
            txtNameKhoa.Clear();
            txtNameMajor.Clear();
            txtCountYear.Clear();
            txtNameClass.Clear();
            txtCountMax.Clear();
            cbbMaGV.Items.Clear();
            cbbMaGV.Text = "";
        }


        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            currentNode = e.Node;
            string tag = (string)currentNode.Tag;
            clearText();
            gbInfo.Enabled = true;
            btnAccept.Enabled = true;
            if (tag == "0")
            {
                btnDelete.Enabled = false;
                pnClass.Enabled = false;
                return;
            }
            btnDelete.Enabled = true;
            pnClass.Enabled = true;
            if (tag == "1")
            {
                txtNameKhoa.Text = currentNode.Text;
            }
            else if (tag == "2")
            {
                txtNameKhoa.Text = currentNode.Parent.Text;
                txtNameMajor.Text = currentNode.Text;
                Major major = Major.getInfo(txtNameMajor.Text);
                txtCountYear.Text = major.getCountYear().ToString();
            }
            else
            {
                txtNameKhoa.Text = currentNode.Parent.Parent.Text;
                txtNameMajor.Text = currentNode.Parent.Text;
                txtNameClass.Text = currentNode.Text;
                Khoa khoa = new Khoa(txtNameKhoa.Text);
                Major major = Major.getInfo(txtNameMajor.Text);
                Class classs = Class.getInfo(txtNameClass.Text);
                txtCountYear.Text = major.getCountYear().ToString();
                txtCountMax.Text = classs.getMaxCount().ToString();
                List<Class> lstClass = Class.getAllClass();
                List<Teacher> teachers = khoa.getTeachers();
                cbbMaGV.Items.Add(classs.getMaGV());
                for (int i = 0; i < teachers.Count; i++)
                {
                    bool isOk = true;
                    for (int j = 0; j < lstClass.Count; j++)
                    {
                        if (teachers[i].getID() == lstClass[j].getMaGV())
                        {
                            isOk = false;
                            break;
                        }
                    }
                    if (isOk)
                    {
                        cbbMaGV.Items.Add(teachers[i].getID());
                        break;
                    }
                }
                cbbMaGV.SelectedIndex = 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageInfo.makeMessage("Question", "Hỏi lại cho chắc", "Bạn có chắn chắn muốn xoá không?") != DialogResult.Yes)
            {
                return;
            }
            string tag = (string)currentNode.Tag;
            if (tag == "1")
            {
                Khoa.deleteKhoa(currentNode.Text);
            }
            else if (tag == "2")
            {
                Major.deleteNganh(currentNode.Text);
            }
            else if (tag == "3")
            {
                Class.deleteClass(currentNode.Text);
            }
            tvKhoa.Nodes.Remove(currentNode);
            NoSelected();
        }

        private void txtNameKhoa_TextChanged(object sender, EventArgs e)
        {
            cbbMaGV.Items.Clear();
            if (string.IsNullOrEmpty(txtNameKhoa.Text))
            {
                return;
            }
            string tag = (string)currentNode.Tag;
            if (tag == "0" || !Khoa.isExistKhoa(txtNameKhoa.Text))
            {
                return;
            }
            Khoa khoa = new Khoa(txtNameKhoa.Text);
            List<Teacher> teachers = khoa.getTeachers();
            List<Class> classs = Class.getAllClass();
            if (tag == "3")
            {
                return;
            }
            for (int j = 0; j < teachers.Count; j++)
            {
                bool isOK = true;
                for (int k = 0; k < classs.Count; k++)
                {
                    if (classs[k].getMaGV() == teachers[j].getID())
                    {
                        isOK = false;
                        break;
                    }
                }
                if (isOK)
                {
                    for (int k = 0; k < cbbMaGV.Items.Count; k++)
                    {
                        if (cbbMaGV.Items[k].ToString() == teachers[j].getID())
                        {
                            isOK = false;
                            break;
                        }
                    }
                    if (isOK)
                    {
                        cbbMaGV.Items.Add(teachers[j].getID());
                    }
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (currentNode == null)
            {
                return;
            }
            string tag = (string)currentNode.Tag;
            if (tag == "0")
            {
                if (string.IsNullOrEmpty(txtNameKhoa.Text))
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập tên khoa!");
                    txtNameKhoa.Focus();
                    return;
                }
                if (Khoa.isExistKhoa(txtNameKhoa.Text))
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên khoa đã tồn tại!");
                    txtNameKhoa.Focus();
                    return;
                }
                if (!Khoa.addKhoa(txtNameKhoa.Text))
                {
                    MessageInfo.makeMessage("Error", "Rất tiếc", "Có lỗi xảy ra!");
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtNameMajor.Text) && !string.IsNullOrEmpty(txtCountYear.Text))
                    {
                        if (Major.isExistsMajor(txtNameMajor.Text))
                        {
                            MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên ngành đã tồn tại!");
                            txtNameMajor.Focus();
                            return;
                        }
                        if (!Major.addMajor(txtNameMajor.Text, txtNameKhoa.Text, int.Parse(txtCountYear.Text)))
                        {
                            MessageInfo.makeMessage("Error", "Rất tiếc", "Có lỗi xảy ra!");
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(txtNameClass.Text) && cbbMaGV.SelectedIndex != -1 && !string.IsNullOrEmpty(txtCountMax.Text))
                            {
                                if (Class.isExistsClass(txtNameClass.Text))
                                {
                                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên lớp đã tồn tại!");
                                    txtNameClass.Focus();
                                    return;
                                }
                                if (!Class.addClass(txtNameClass.Text, cbbMaGV.Text, int.Parse(txtCountMax.Text), txtNameMajor.Text))
                                {
                                    MessageInfo.makeMessage("Error", "Rất tiếc", "Có lỗi xảy ra!");
                                }
                            }
                        }
                    }
                }
            }
            else if (tag == "1")
            {
                if (string.IsNullOrEmpty(txtNameKhoa.Text)) //sửa khoa
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập tên khoa!");
                    txtNameKhoa.Text = currentNode.Text;
                    txtNameKhoa.Focus();
                    return;
                }
                if (txtNameKhoa.Text != currentNode.Text && Khoa.isExistKhoa(txtNameKhoa.Text))
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên khoa đã tồn tại!");
                    txtNameKhoa.Focus();
                    return;
                }
                Khoa khoa = new Khoa(currentNode.Text);
                if (!khoa.updateKhoa(txtNameKhoa.Text))
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Cập nhật khoa thất bại!");
                    txtNameKhoa.Focus();
                    return;
                }

                if (!string.IsNullOrEmpty(txtNameMajor.Text) && !(string.IsNullOrEmpty(txtCountYear.Text)))
                {
                    if (Major.isExistsMajor(txtNameMajor.Text))
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên ngành đã tồn tại!");
                        txtNameMajor.Focus();
                        return;
                    }
                    if (!Major.addMajor(txtNameMajor.Text, txtNameKhoa.Text, int.Parse(txtCountYear.Text)))
                    {
                        MessageInfo.makeMessage("Error", "Rất tiếc", "Có lỗi xảy ra!");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(txtNameClass.Text) && cbbMaGV.SelectedIndex != -1 && !string.IsNullOrEmpty(txtCountMax.Text))
                        {
                            if (Class.isExistsClass(txtNameClass.Text))
                            {
                                MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên lớp đã tồn tại!");
                                txtNameClass.Focus();
                                return;
                            }
                            if (!Class.addClass(txtNameClass.Text, cbbMaGV.Text, int.Parse(txtCountMax.Text), txtNameMajor.Text))
                            {
                                MessageInfo.makeMessage("Error", "Rất tiếc", "Có lỗi xảy ra!");
                            }
                        }
                        else
                        {
                            MessageInfo.makeMessage("Warning", "Cảnh báo", "Không thể thêm lớp vì không đủ thông tin!");
                        }
                    }
                }
                else
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Không thể thêm ngành, lớp vì không đủ thông tin!");
                }

            }
            else if (tag == "2")
            {
                if (string.IsNullOrEmpty(txtNameKhoa.Text)) //sửa khoa
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập tên khoa để sửa!");
                    txtNameKhoa.Text = currentNode.Parent.Text;
                    txtNameKhoa.Focus();
                    return;
                }
                if (txtNameKhoa.Text != currentNode.Parent.Text && Khoa.isExistKhoa(txtNameKhoa.Text))
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên khoa đã tồn tại!");
                    txtNameKhoa.Focus();
                    return;
                }
                Khoa khoa = new Khoa(currentNode.Parent.Text);
                if (!khoa.updateKhoa(txtNameKhoa.Text))
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Cập nhật khoa thất bại!");
                    txtNameKhoa.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(txtNameMajor.Text) && !string.IsNullOrEmpty(txtCountYear.Text))
                {
                    Major major = Major.getInfo(currentNode.Text);
                    if (txtNameMajor.Text != currentNode.Text && Major.isExistsMajor(txtNameMajor.Text))
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên ngành đã tồn tại!");
                        txtNameMajor.Focus();
                        return;
                    }
                    if (!major.updateMajor(txtNameMajor.Text, int.Parse(txtCountYear.Text), txtNameKhoa.Text))
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Cập nhật ngành thất bại!");
                        txtNameMajor.Focus();
                        return;
                    }
                    if (!string.IsNullOrEmpty(txtNameClass.Text) && cbbMaGV.SelectedIndex != -1 && !string.IsNullOrEmpty(txtCountMax.Text))
                    {
                        if (Class.isExistsClass(txtNameClass.Text))
                        {
                            MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên lớp đã tồn tại!");
                            txtNameClass.Focus();
                            return;
                        }
                        if (!Class.addClass(txtNameClass.Text, cbbMaGV.Text, int.Parse(txtCountMax.Text), txtNameMajor.Text))
                        {
                            MessageInfo.makeMessage("Error", "Rất tiếc", "Có lỗi xảy ra!");
                        }
                    }
                    else
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Không thể thêm lớp vì không đủ thông tin!");
                    }

                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtNameKhoa.Text)) //sửa khoa
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Bạn chưa nhập tên khoa để sửa!");
                    txtNameKhoa.Text = currentNode.Parent.Parent.Text;
                    txtNameKhoa.Focus();
                    return;
                }
                if (txtNameKhoa.Text != currentNode.Parent.Parent.Text && Khoa.isExistKhoa(txtNameKhoa.Text))
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên khoa đã tồn tại!");
                    txtNameKhoa.Focus();
                    return;
                }
                Khoa khoa = new Khoa(currentNode.Parent.Parent.Text);
                if (!khoa.updateKhoa(txtNameKhoa.Text))
                {
                    MessageInfo.makeMessage("Warning", "Cảnh báo", "Cập nhật khoa thất bại!");
                    txtNameKhoa.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(txtNameMajor.Text) && !string.IsNullOrEmpty(txtCountYear.Text))
                {
                    Major major = Major.getInfo(currentNode.Parent.Text);
                    if (txtNameMajor.Text != currentNode.Parent.Text && Major.isExistsMajor(txtNameMajor.Text))
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên ngành đã tồn tại!");
                        txtNameMajor.Focus();
                        return;
                    }
                    if (!major.updateMajor(txtNameMajor.Text, int.Parse(txtCountYear.Text), txtNameKhoa.Text))
                    {
                        MessageInfo.makeMessage("Warning", "Cảnh báo", "Cập nhật ngành thất bại!");
                        txtNameMajor.Focus();
                        return;
                    }
                    if (!string.IsNullOrEmpty(txtNameClass.Text) && cbbMaGV.SelectedIndex != -1 && !string.IsNullOrEmpty(txtCountMax.Text))
                    {
                        if (txtNameClass.Text != currentNode.Text && Class.isExistsClass(txtNameClass.Text))
                        {
                            MessageInfo.makeMessage("Warning", "Cảnh báo", "Tên lớp đã tồn tại!");
                            txtNameClass.Focus();
                            return;
                        }
                        Class classs = Class.getInfo(currentNode.Text);
                        if (!classs.updateClass(txtNameClass.Text, cbbMaGV.Text, int.Parse(txtCountMax.Text), txtNameMajor.Text))
                        {
                            MessageInfo.makeMessage("Error", "Rất tiếc", "Cập nhật lớp thất bại!");
                        }
                    }
                }
            }
            uploadInfo();
        }
    }
}
