/**
 * ---------------------------------------------------------
 * This program is specially designed for ADT-Team.com
 * @author GROM - <botx68@gmail.com>
 * @WebSite: http://adt-team.com
 * @About: The program automates firewall windows
 * @Date: 02.04.2016
 *----------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortForwardADT
{
    public partial class PortForwardADT : Form
    {
        public PortForwardADT()
        {
            InitializeComponent();
        }

        private void TextPort_TextChanged(object sender, EventArgs e)
        {

            // Проверяем поле ввода и разрешаем вводить только цыфры.
            Regex Regular = new Regex(@"^[0-9 ]+$");

            if (Regular.IsMatch(TextPort.Text))
            {
            }
            else
            {
                MessageBox.Show("Разрешены только цифры.", "ADT-Team:  Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Имя правила
        private void PortsNames_TextChanged(object sender, EventArgs e)
        {

        }


        private void TcpCheck_CheckedChanged(object sender, EventArgs e)
        {
            //if (TcpCheck.Checked) UdpCheck.Checked = false;
        }

        private void UdpCheck_CheckedChanged(object sender, EventArgs e)
        {
            //if (UdpCheck.Checked) TcpCheck.Checked = false;
        }


        private void Incoming_CheckedChanged(object sender, EventArgs e)
        {
            // if (Incoming.Checked) Outbound.Checked = false;
        }

        private void Outbound_CheckedChanged(object sender, EventArgs e)
        {
            // if (Outbound.Checked) Incoming.Checked = false;
        }


        private void AllowСonnection_CheckedChanged(object sender, EventArgs e)
        {
            if (AllowСonnection.Checked) EnableSecureConnection.Checked = false;
            if (AllowСonnection.Checked) BlockConnection.Checked = false;


        }

        private void EnableSecureConnection_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableSecureConnection.Checked) AllowСonnection.Checked = false;
            if (EnableSecureConnection.Checked) BlockConnection.Checked = false;
        }

        private void BlockConnection_CheckedChanged(object sender, EventArgs e)
        {
            if (BlockConnection.Checked) AllowСonnection.Checked = false;
            if (BlockConnection.Checked) EnableSecureConnection.Checked = false;


        }

        private void OpenPorts_Click(object sender, EventArgs e)
        {
            string getPorts = TextPort.Text;   // Получаем порт 
            string getNames = PortsNames.Text; // Поулучаем имя
            string sCheckBox = null;
            string Protocol = null;
            string Dir = null;

            /*
             *-----------------------------------------------------------------------------* 
             * in – правило создается только для входящего трафика и в оснастке «Брандмауэр Windows в режиме повышенной безопасности» его можно будет найти в узле «Правила для входящих подключений». 
             
             * out – правило создается только для исходящего трафика и в оснастке «Брандмауэр Windows в режиме повышенной безопасности» его можно будет найти в узле «Правила для исходящих подключений».
             *------------------------------------------------------------------------------*
             */
            if (Incoming.Checked)
            {
                Dir = "in";
            }

            if (Outbound.Checked)
            {
                Dir = "out";
            }

            /*
             *-----------------------------------------------------------------------------* 
             * allow – разрешает сетевые пакеты, которые отвечают всем условиям в правиле брандмауэра; 
             
             * block – позволяет явно заблокировать любой сетевой пакет, который отвечает условиям правила брандмауэра. 
               Действие блокирования имеет преимущество перед действием разрешения; 
             
             * bypass – разрешает только подключения, защищенные с помощью протокола IPsec.
             *------------------------------------------------------------------------------*
             */

            if (AllowСonnection.Checked)
            {
                sCheckBox = "allow";
            }
            if (EnableSecureConnection.Checked)
            {
                sCheckBox = "bypass";
            }
            if (BlockConnection.Checked)
            {
                sCheckBox = "block";
            }


            if (TcpCheck.Checked == false && UdpCheck.Checked == false)
            {
                MessageBox.Show("Выберите протокол TCP/UDP", "ADT-Team: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //TCP 
            if (TcpCheck.Checked)
            {
                Protocol = "TCP";

                if (Outbound.Checked == false && Incoming.Checked == false)
                {
                    MessageBox.Show("Пожалуйста выберите правило для входящих и (или) исходящих подключени.", "ADT-Team: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    // Если обе галочки нажаты для входящих/исходящих.
                    if (Incoming.Checked && Outbound.Checked)
                    {
                        Process.Start("cmd.exe", "/C " + "netsh advfirewall firewall add rule name=" + getNames + " " + "dir=" + "in" + " " + "action=" + sCheckBox + " " + "protocol=" + Protocol + " " + "enable=yes");
                        Process.Start("cmd.exe", "/C " + "netsh advfirewall firewall add rule name=" + getNames + " " + "dir=" + "out" + " " + "action=" + sCheckBox + " " + "protocol=" + Protocol + " " + "enable=yes");

                    }
                    else // Если выбрана определенная галочка in/out
                    {
                        Process.Start("cmd.exe", "/C " + "netsh advfirewall firewall add rule name=" + getNames + " " + "dir=" + Dir + " " + "action=" + sCheckBox + " " + "protocol=" + Protocol + " " + "enable=yes");
                    }
            }


            //UDP
            if (UdpCheck.Checked)
            {
                Protocol = "UDP";
                if (Outbound.Checked == false && Incoming.Checked == false)
                {
                    MessageBox.Show("Пожалуйста выберите правило для входящих и (или) исходящих подключени.", "ADT-Team: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    // Если обе галочки нажаты для входящих/исходящих.
                    if (Incoming.Checked && Outbound.Checked)
                    {
                        Process.Start("cmd.exe", "/C " + "netsh advfirewall firewall add rule name=" + getNames + " " + "dir=" + "in" + " " + "action=" + sCheckBox + " " + "protocol=" + Protocol + " " + "enable=yes");
                        Process.Start("cmd.exe", "/C " + "netsh advfirewall firewall add rule name=" + getNames + " " + "dir=" + "out" + " " + "action=" + sCheckBox + " " + "protocol=" + Protocol + " " + "enable=yes");
                    }
                    else // Если выбрана определенная галочка in/out
                    {
                        Process.Start("cmd.exe", "/C " + "netsh advfirewall firewall add rule name=" + getNames + " " + "dir=" + Dir + " " + "action=" + sCheckBox + " " + "protocol=" + Protocol + " " + "enable=yes");
                    }
            }
        }
    }
}
