namespace Wasm.Modal;

public class ModalModel(Type contentType, string? title, bool staticBackdrop)
{
    public Type ContentType { get; } = contentType;
    public bool HasStaticBackdrop { get; } = staticBackdrop;
    public string? ShowCloseButton { get; } = title;
    public string? Title { get; } = title;
}