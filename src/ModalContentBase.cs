using Microsoft.AspNetCore.Components;

namespace Wasm.Modal;

public abstract class ModalContentBase : ComponentBase
{
    [CascadingParameter] public IModalDialog ModalDialog { get; set; } = default!;
}