using Microsoft.AspNetCore.Components;

namespace Wasm.Modal;

public interface IModalManager
{
    event EventHandler<CreateModalEventArgs> OnCreateModal;
    ValueTask CreateModalAsync<T>(string? title = null, bool staticBackdrop = true) where T : ModalContentBase;
}