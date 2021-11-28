using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_de_Programação_Orientada_a_Objetos
{
    class Jovem
    {
        public enum Generos {Homem, Mulher}

        static List<Jovem> _Jovens = new List<Jovem>();
        static int lastId = 1; 

        int _Id;
        String _Nome;
        Generos _Genero;
        int _Status;

        public Jovem() { }
        public Jovem(string nome, Generos genero, int status)
        {
            _Nome = nome;
            _Genero = genero;
            _Status = status;
        }

        public int ID
        {
            set { _Id = value; }
            get { return _Id; }
        }

        public String Nome
        {
            set { _Nome = value; }
            get { return _Nome; }
        }

        public Generos Genero
        {
            set { _Genero = value; }
            get { return _Genero; }
        }

        public int Status
        {
            set { _Status = value; }
            get { return _Status; }
        }

        public void Adicionar(Jovem j) 
        {
            _Id = lastId++;
            _Jovens.Add(this);    
        }

        public static List<Jovem> Listar()
        {
            return _Jovens;
        }
    }
}
