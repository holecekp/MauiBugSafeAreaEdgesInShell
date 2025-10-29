using MauiBugSafeAreaEdgesInShell.Models;

namespace MauiBugSafeAreaEdgesInShell.Pages
{
    public partial class ProjectDetailPage : ContentPage
    {
        public ProjectDetailPage(ProjectDetailPageModel model)
        {
            InitializeComponent();

            BindingContext = model;
        }
    }
}
