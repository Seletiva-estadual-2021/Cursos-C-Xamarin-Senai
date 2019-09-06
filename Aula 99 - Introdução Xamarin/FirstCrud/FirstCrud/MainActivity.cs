using Android.App;
using Android.Widget;
using Android.OS;
using System;
using FirstCrud.model;
using FirstCrud.controller;

namespace FirstCrud
{
    [Activity(Label = "FirstCrud", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText txtNome;
        EditText txtEmail;
        Button btnSalvar;
        Button btnListPessoas;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            setFieldsAndMethods();
        }

        private void setFieldsAndMethods()
        {
            txtNome = FindViewById<EditText>(Resource.Id.txtNome);
            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            btnSalvar = FindViewById<Button>(Resource.Id.btnSalvar);
            btnListPessoas = FindViewById<Button>(Resource.Id.btnListPessoas);

            btnSalvar.Click += Salvar;
            btnListPessoas.Click += ListarPessoas;
        }

        private void ListarPessoas(object sender, EventArgs e)
        {
            StartActivity(typeof(ListagemPessoas));
        }

        private void Salvar(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa(txtNome.Text, txtEmail.Text);

            PessoaDao pdao = new PessoaDao();
            pdao.makeModelTable();
            string status = pdao.InserirPessoa(p) ? "Salvo com sucesso!!" : "Erro ao salvar";
            Toast.MakeText(this, status, ToastLength.Long).Show();
        }
    }
}

