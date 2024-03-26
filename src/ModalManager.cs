using Microsoft.AspNetCore.Components;

namespace Wasm.Modal;

internal class ModalManager : IModalManager
{
    private EventHandler<CreateModalEventArgs>? _onCreateModal;
    public event EventHandler<CreateModalEventArgs> OnCreateModal
    {
        add => _onCreateModal += value;
        remove => _onCreateModal -= value;
    }

    public ValueTask CreateModalAsync<T>(string? title = null, bool staticBackdrop = true) where T: ModalContentBase
    {
        _onCreateModal?.Invoke(this, new CreateModalEventArgs(typeof(T), new ModalModel(typeof(T), title, staticBackdrop)));
        return ValueTask.CompletedTask;
    }
}