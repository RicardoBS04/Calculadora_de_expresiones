using System;
using System.Windows.Forms;

public class FrmHistorial : Form
{
    private DataGridView dgvHistorial;

    public FrmHistorial(string csv)
    {
        InicializarUI();
        CargarHistorial(csv);
    }

    private void InicializarUI()
    {
        this.Text = "Historial";
        this.Size = new System.Drawing.Size(600, 400);
        this.StartPosition = FormStartPosition.CenterScreen;

        dgvHistorial = new DataGridView();
        dgvHistorial.Dock = DockStyle.Fill;
        dgvHistorial.ReadOnly = true;
        dgvHistorial.AllowUserToAddRows = false;
        dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        this.Controls.Add(dgvHistorial);
    }

    private void CargarHistorial(string csv)
    {
        dgvHistorial.Rows.Clear();
        dgvHistorial.Columns.Clear();

        dgvHistorial.Columns.Add("Expresion", "Expresión");
        dgvHistorial.Columns.Add("Fecha", "Fecha");
        dgvHistorial.Columns.Add("Resultado", "Resultado");

        dgvHistorial.ReadOnly = true;
        dgvHistorial.AllowUserToAddRows = false;
        dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        if (string.IsNullOrWhiteSpace(csv))
            return;

        string[] lineas = csv.Split('\n');
        for (int i = 1; i < lineas.Length; i++)
        {
            string linea = lineas[i].Trim();

            if (string.IsNullOrWhiteSpace(linea))
                continue;

            string[] partes = linea.Split(',');

            if (partes.Length != 3)
                continue;

            dgvHistorial.Rows.Add(
                partes[0], 
                partes[1], 
                partes[2]  
            );
        }
    }

}
