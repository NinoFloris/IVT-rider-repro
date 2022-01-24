// Cannot access internal constructor 'X' here
new lib.X();

class Foo : lib.IFoo
{
    // The constraints for type parameter 'T' of method 'Foo.Invoke<T>' must match the constraints for type parameter 'T'
    // of interface method 'lib.IFoo.Invoke<T>'. Consider using an explicit interface implementation instead.
    public void Invoke<T>(T value)
        where T : ICloneable
    {
    }
}
