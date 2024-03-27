namespace Wasm.Modal;

public class ModalModel(Type childContentType, string title, bool hasStaticBackdrop = false, bool hideCloseButton = false)
{
    public Type ChildContentType { get; } = childContentType;
    public bool HasStaticBackdrop { get; } = hasStaticBackdrop;
    public bool HideCloseButton { get; } = hideCloseButton;
    public string Title { get; } = title;
}