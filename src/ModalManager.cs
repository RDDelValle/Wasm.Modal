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

    public ValueTask CreateModalAsync<T>(string title, bool hasStaticBackdrop = false, bool hideCloseButton = false) where T: IComponent
    {
        _onCreateModal?.Invoke(this, new CreateModalEventArgs(new ModalModel(typeof(T), title, hasStaticBackdrop, hideCloseButton)));
        return ValueTask.CompletedTask;
    }
}