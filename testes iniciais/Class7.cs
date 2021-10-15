﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }
        public double ValorTotalEmEstoque
        {
            get { return _preco * _quantidade; }
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        
    }
}