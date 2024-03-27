using Microsoft.AspNetCore.Components;

namespace Wasm.Modal;

public interface IModalManager
{
    event EventHandler<CreateModalEventArgs> OnCreateModal;
    ValueTask CreateModalAsync<T>(string title, bool hasStaticBackdrop = false, bool hideCloseButton = false) where T : IComponent;
}