using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FirstCrud.controller;
using FirstCrud.model;

namespace FirstCrud
{
    [Activity(Label = "ListagemPessoas")]
    public class ListagemPessoas : ListActivity
    {
        ListView pessoas;
        PessoaDao pdao = new PessoaDao();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            setFieldsAndMethods();
        }

        private void setFieldsAndMethods()
        {
            pessoas = FindViewById<ListView>(Resource.Id.list);
            ListAdapter = new ArrayAdapter<Pessoa>(this, Android.Resource.Layout.SimpleListItem1, pdao.GetPessoas());
        }
    }
}