namespace Wasm.Modal;

public interface IModal
{
    Task CloseModalDialogAsync(Type type);
}