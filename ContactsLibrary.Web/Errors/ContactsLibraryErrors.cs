public class ContactLibraryException : System.Exception{
    public ContactLibraryException() { }
    public ContactLibraryException(string message) : base(message) { }
    public ContactLibraryException(string message, System.Exception inner) : base(message, inner) { }
    protected ContactLibraryException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}