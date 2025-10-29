using CommunityToolkit.Mvvm.Input;
using MauiBugSafeAreaEdgesInShell.Models;

namespace MauiBugSafeAreaEdgesInShell.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}