using Act.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBpatente_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBpatente_Enter(object sender, EventArgs e)
        {
            tBpatente.Clear();
        }

        private void tBpatente_Leave(object sender, EventArgs e)
        {
        }
        Agencia ag = new Agencia();
        private void bGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket t = null;
                
                if (rBdenuncia.Checked)
                {
                    string pat = tBpatente.Text;
                    Vehiculo v = ag.BuscarVehiculo(pat);
                    if (v != null)
                    {
                        t = new Denuncia(v);
                        ag.AgregarTicket(t);
                        
                    }
                    else
                    {
                        MessageBox.Show("Vehiculo no registrado");
                    }
                }
                if(rBcliente.Checked)
                {
                    long dni = Convert.ToInt32(tBdni.Text);
                    t = new Cliente(dni);
                    ag.AgregarTicket(t);
                }
                lBtickets.Items.Add(t);
            }
            catch(DniInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bImportar_Click(object sender, EventArgs e)
        {
            FileStream fs= null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream("autos.csv", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(';');
                    Cliente c = new Cliente(Convert.ToInt32(campos[0]));
                    Vehiculo v = new Vehiculo(campos[1], c);
                    ag.AgregarVehiculo(v);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ver ver = new Ver();
            foreach(Vehiculo v in ag.vehiculos)
            {
                ver.listBox1.Items.Add(v.patente);
            }
            ver.ShowDialog();
        }

        private void bExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivos CSV|*.csv";
            FileStream fs = null;
            StreamWriter sw = null;
            Ticket t = null;
            try
            {
                if(save.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(save.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("tipo;cliente;denuncia");
                    sw.WriteLine("cliente;nro;fecha;dni");
                    sw.WriteLine("denuncia;nro;fecha;patente");
                    for (int i = 0; i < ag.atendidos.Count; i++)
                    {
                        t = ag.atendidos[i];
                        if (t is Cliente)
                        {
                            t = t as Cliente;
                            sw.WriteLine($"cliente;{t.VerNro()};{t.VerFechaHora()};");
                        }
                        if (t is Denuncia)
                        {
                            t = (Denuncia)t;
                            sw.WriteLine($"denuncia;{t.VerNro()};{t.VerFechaHora()};");
                        }
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(fs!= null)fs.Close();
                if(sw!= null)sw.Close();
            }
        }

        private void bDenuncia_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket t = ag.AtenderTicket(0);
                lBtickets.Items.Remove(t);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void bCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket t = ag.AtenderTicket(1);
                lBtickets.Items.Remove(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
