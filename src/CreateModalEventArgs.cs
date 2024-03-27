namespace Wasm.Modal;

public class CreateModalEventArgs(ModalModel model)
{
    public ModalModel Model { get; } = model;
}