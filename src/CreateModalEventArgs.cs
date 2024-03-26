namespace Wasm.Modal;

public class CreateModalEventArgs(Type type, ModalModel model)
{
    public Type Type { get; } = type;
    public ModalModel Model { get; } = model;
}