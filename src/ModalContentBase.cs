using Microsoft.AspNetCore.Components;

namespace Wasm.Modal;

public abstract class ModalContentBase : ComponentBase
{
    [CascadingParameter] public IModal Modal { get; set; } = default!;
}