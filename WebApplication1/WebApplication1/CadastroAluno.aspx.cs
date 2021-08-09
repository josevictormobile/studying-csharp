using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class CadastroAluno : System.Web.UI.Page
    {
        public static List<Aluno> Alunos = new List<Aluno>();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = Alunos;
            GridView1.DataBind();
            Response.Write("A página carregou <script>document.write(Date())</script>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = TextBox1.Text;
            aluno.Matrícula = TextBox2.Text;
            aluno.Notas.Add(Convert.ToDouble(TextBox3.Text));
            aluno.Notas.Add(Convert.ToDouble(TextBox4.Text));
            aluno.Notas.Add(Convert.ToDouble(TextBox5.Text));
            aluno.Notas.Add(Convert.ToDouble(TextBox6.Text));
            aluno.CalculaMedia();
            aluno.VerificaStatus();
            Alunos.Add(aluno);
            Page_Load(sender, e);

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}