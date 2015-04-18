using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Cadastro_de_funcionarios
{
    partial class Form1 : Form
    {
        private Funcionario temp;
        List<Funcionario> Func = new List<Funcionario>();
        public bool editing;

        public void load()
        {
            string[] lines = System.IO.File.ReadAllLines("SaveLog.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                Func.Add(new Funcionario());
                Func[i].BackFromText(lines[i]);
                Funcionários.Items.Add(Func[i].Nome + ":" + Func[i].Profissao);
            }                
        }
        
        public Form1()
        {
            InitializeComponent();
            temp = new Funcionario();
            load();
            confirmar.Enabled = false;
            editing = false;
        }
        private void Nome_TextChanged(object sender, EventArgs e)
        {
            nome.Text = Regex.Replace(Convert.ToString(nome.Text), "(?i)[^a-z À-ÿ]", "");
            profissão.Text = Regex.Replace(Convert.ToString(profissão.Text), "(?i)[^a-z À-ÿ]", "");
            endereço.Text = Regex.Replace(Convert.ToString(endereço.Text), "(?i)[^a-z À-ÿ][^0-9]", "");
            relacionamento.Text = Regex.Replace(Convert.ToString(relacionamento.Text), "(?i)[^a-z À-ÿ][(][)]", "");
            salario.Text = Regex.Replace(Convert.ToString(salario.Text), "[^0-9]", "");
            numdefilhos.Text = Regex.Replace(Convert.ToString(numdefilhos.Text), "[^0-9]", "");
            idade.Text = Regex.Replace(Convert.ToString(idade.Text), "[^0-9]", "");
            tel.Text = Regex.Replace(Convert.ToString(tel.Text), "[^0-9][(][)]", "");
            confirmar.Enabled = false;
        }
        public void salvar()
        {
            string[] texto = new string[1];
            texto[0] = temp.ToText();
            System.IO.File.AppendAllLines("SaveLog.txt", texto);
        }           

        private void confirm_click(object sender, EventArgs e)
        {
            if (!editing)
            {
                temp.setup(nome.Text, profissão.Text, sexo.Text, relacionamento.Text, tiposanguineo.Text, endereço.Text, email.Text,
                    (idade.Text), (salario.Text), (tel.Text), (numdefilhos.Text));
                Funcionários.Items.Add(temp.Nome + ":" + temp.Profissao);
                Func.Add(temp);
                nome.Text = "";
                profissão.Text = "";
                sexo.Text = "";
                relacionamento.Text = "";
                tiposanguineo.Text = "";
                endereço.Text = "";
                email.Text = "";
                idade.Text = "";
                salario.Text = "";
                tel.Text = "";
                numdefilhos.Text = "";
                salvar();
            }

            else
            {
                if (Funcionários.SelectedIndex > -1)
                {
                    string[] allLines = System.IO.File.ReadAllLines("SaveLog.txt");

                    for (int i = 0; i < allLines.Length; i++)
                    {
                        if (Func[Funcionários.SelectedIndex].ToText().Equals(allLines[i]))
                        {
                            Func[Funcionários.SelectedIndex].setup(nome.Text, profissão.Text, sexo.Text, relacionamento.Text, tiposanguineo.Text, endereço.Text, email.Text,
                            (idade.Text), (salario.Text), (tel.Text), (numdefilhos.Text));
                            allLines[i] =  Func[Funcionários.SelectedIndex].ToText();
                        }
                    }
                    nome.Text = "";
                    profissão.Text = "";
                    sexo.Text = "";
                    relacionamento.Text = "";
                    tiposanguineo.Text = "";
                    endereço.Text = "";
                    email.Text = "";
                    idade.Text = "";
                    salario.Text = "";
                    tel.Text = "";
                    numdefilhos.Text = "";
                    System.IO.File.WriteAllLines("SaveLog.txt", allLines);
                }
            }

            editing = false;
            confirmar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void Verificar_Click(object sender, EventArgs e)
        {
            int charcountEm = 0;
            int charcountTel = 0;
            if (!string.IsNullOrWhiteSpace(nome.Text) && !string.IsNullOrWhiteSpace(profissão.Text) && !string.IsNullOrWhiteSpace(sexo.Text)
                && !string.IsNullOrWhiteSpace(relacionamento.Text) && !string.IsNullOrWhiteSpace(tiposanguineo.Text) && !string.IsNullOrWhiteSpace(endereço.Text)
                && !string.IsNullOrWhiteSpace(email.Text) && !string.IsNullOrWhiteSpace(idade.Text) && !string.IsNullOrWhiteSpace(salario.Text)
                && !string.IsNullOrWhiteSpace(tel.Text) && !string.IsNullOrWhiteSpace(numdefilhos.Text))
            {
                foreach (char a in email.Text)
                {
                    if (a.Equals('@'))
                    {
                        charcountEm++;
                    }

                    if(a.Equals('#'))
                    {
                        charcountEm += 5;
                    }
                }
                string [] EmT = email.Text.Split('@');
                
                foreach (char a in tel.Text)
                {
                    charcountTel++;
                }

                if ((charcountEm == 0 || charcountEm > 1 || EmT.Length < 2) || (int.Parse(idade.Text) > 88 || int.Parse(idade.Text) < 16) || (charcountTel < 12 || charcountTel > 13))
                {
                    if ((charcountEm == 0 || charcountEm > 1 || EmT.Length < 2))
                    {
                        label13.ForeColor = Color.Red;
                    }

                    else 
                    { 
                        label13.ForeColor = Form1.DefaultBackColor; 
                    }

                    if ((int.Parse(idade.Text) > 99 || int.Parse(idade.Text) < 18))
                    {
                        label14.ForeColor = Color.Red;
                    }

                    else 
                    {
                        label14.ForeColor = Form1.DefaultBackColor; 
                    }

                    if ((charcountTel < 12 || charcountTel > 13))
                    {
                        label15.ForeColor = Color.Red;
                    }
                    else 
                    { 
                        label15.ForeColor = Form1.DefaultBackColor;
                    }
                }
                else
                {
                    confirmar.Enabled = true;
                    label12.ForeColor = Form1.DefaultBackColor;
                    label13.ForeColor = Form1.DefaultBackColor;
                    label14.ForeColor = Form1.DefaultBackColor;
                    label15.ForeColor = Form1.DefaultBackColor;
                }
            }
                
            else
            {
                label12.ForeColor = Color.Red;
            }
        }


        private void Editar_Click(object sender, EventArgs e)
        {
            if (Funcionários.SelectedIndex > -1)
            {
                editing = true;
                nome.Text = Func[Funcionários.SelectedIndex].Nome;
                profissão.Text = Func[Funcionários.SelectedIndex].Profissao;
                sexo.Text = Func[Funcionários.SelectedIndex].Genero;
                relacionamento.Text = Func[Funcionários.SelectedIndex].EstCiv;
                tiposanguineo.Text = Func[Funcionários.SelectedIndex].SangTip;
                endereço.Text = Func[Funcionários.SelectedIndex].Endereço;
                email.Text = Func[Funcionários.SelectedIndex].Email;
                idade.Text = Func[Funcionários.SelectedIndex].Idade;
                salario.Text = Func[Funcionários.SelectedIndex].Salario;
                tel.Text = Func[Funcionários.SelectedIndex].Telefone;
                numdefilhos.Text = Func[Funcionários.SelectedIndex].Filhos;
            }
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            if (Funcionários.SelectedIndex > -1)
            {
                Func.RemoveAt(Funcionários.SelectedIndex);
                Funcionários.Items.RemoveAt(Funcionários.SelectedIndex);
                string[] reWrite = new string[Func.Count];
                for (int i = 0; i < Func.Count; i++)
                {
                    reWrite[i] = Func[i].ToText();
                }

                nome.Text = "";
                profissão.Text = "";
                sexo.Text = "";
                relacionamento.Text = "";
                tiposanguineo.Text = "";
                endereço.Text = "";
                email.Text = "";
                idade.Text = "";
                salario.Text = "";
                tel.Text = "";
                numdefilhos.Text = "";
                System.IO.File.WriteAllLines("Save.txt", reWrite);
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Ah-Ha , não há mais nada aqui , pode seguir seu caminho :D
        }
        }
    }