namespace Wasm.Modal;

public class ModalModel(Type content, string? title, bool staticBackdrop)
{
    public bool HasStaticBackdrop { get; } = staticBackdrop;
    public string? ShowCloseButton { get; } = title;
    public string? Title { get; } = title;
}