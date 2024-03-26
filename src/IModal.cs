namespace Wasm.Modal;

public interface IModal
{
    Task CloseModalAsync(Type type);
}