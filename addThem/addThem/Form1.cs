using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addThem
{
    public partial class Form1 : Form
    {
        private List<Member> _members = new List<Member>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string memberFirstName = tbFirst.Text,
                memberLastName = tbLast.Text,
                memberAddress = tbAddress.Text,
                memberPhone = tbPhone.Text;
            int memberAge;
            if (!string.IsNullOrWhiteSpace(memberFirstName) && !string.IsNullOrWhiteSpace(memberLastName) && !string.IsNullOrWhiteSpace(memberAddress) && !string.IsNullOrWhiteSpace(memberPhone) && int.TryParse(tbAge.Text, out memberAge))
            {
                Member member = new Member(memberFirstName, memberLastName, memberAddress, memberPhone, memberAge);
                _members.Add(member);
                RefreshMemberList();

                tbFirst.Text = string.Empty;
                tbLast.Text = string.Empty;
                tbAddress.Text = string.Empty;
                tbPhone.Text = string.Empty;
                tbPhone.Text = string.Empty;

                MessageBox.Show("Them thanh cong");

            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshMemberList();
        }
        
        private void RefreshMemberList()
        {
            dgvMembers.Rows.Clear();
            foreach (var member in _members)
            {
                dgvMembers.Rows.Add(member.firstName, member.LastName, member.address, member.phone, member.Age);
            }
        }
        
        
    }
}

public class Member
{
    public string firstName { get; set; }
    
    public string LastName { get; set; }
    
    public string address { get; set; }
    
    public string phone { get; set; }
    public int Age { get; set; }


    public Member(string firstName, string lastName, string address, string phone, int age)
    {
        this.firstName = firstName;
        LastName = lastName;
        this.address = address;
        this.phone = phone;
        Age = age;
    }
}