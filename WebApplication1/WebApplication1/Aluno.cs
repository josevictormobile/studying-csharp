using System;
using System.Collections.Generic;

public class Aluno	
{
	public string Nome { get; set; }
	public string Matrícula { get; set; }
	public List<double> Notas;

	public Aluno()
	{
		this.Notas = new List<double>();//QUANDO A INSTÂNCIA DE ALUNO É CONSTRUÍDA UMA INSTÂNCIA DE SUA LISTA DE NOTAS É ATRIBUÍDA PARA ELA;
	}


}
