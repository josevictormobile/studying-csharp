using System;
using System.Collections.Generic;

public class Aluno	
{
	public string Nome { get; set; }
	public string Matrícula { get; set; }
	public List<double> Notas;
	public double Media { get; set; }
	public string Status { get; set; }

	public Aluno()
	{
		this.Notas = new List<double>();//QUANDO A INSTÂNCIA DE ALUNO É CONSTRUÍDA UMA INSTÂNCIA DE SUA LISTA DE NOTAS É ATRIBUÍDA PARA ELA;
	}

	public void CalculaMedia()
    {
		foreach (var nota in this.Notas)
        {
			this.Media += nota;
        }
		this.Media /= 4;
    }

	public void VerificaStatus()
    {
		this.Status = this.Media >= 7 ? "Aprovado" : "Reprovado";
    }


}
