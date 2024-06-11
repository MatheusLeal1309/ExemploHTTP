using CommunityToolkit.Mvvm.ComponentModel;
using ExemploHTTP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ExemploHTTP.ViewModel
{
    public partial class PostagemViewModel : ObservableObject
    {
        private readonly RestService _restService;

        public PostagemViewModel()
        {
            _restService = new RestService();
            GetPostagensAsyncCommand = new Command(async () => await GetPostagemAsync());
        }

        [ObservableProperty]
        private int _userId;

        [ObservableProperty]
        private int _id;

        [ObservableProperty]
        private string _title;

        [ObservableProperty]
        private string _body;

        public ICommand GetPostagensAsyncCommand { get; }
        
        [ObservableProperty]
        private ObservableCollection<Postagem> _postagens = new ObservableCollection<Postagem>();

        public async Task  GetPostagemAsync()
        {
            Postagens = await _restService.GetPostagensAsync();
        }
    }
}
