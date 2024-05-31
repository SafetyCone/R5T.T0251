using System;

using R5T.T0142;


namespace R5T.T0251
{
    /// <summary>
    /// Similar to the <see cref="ObsoleteAttribute"/>, but without the Visual Studio built-in warning.
    /// </summary>
    /// <remarks>
    /// Allowed on all application elements.
    /// Multiple are allowed (although discouraged).
    /// Inherited is false; just because the base class has moved doesn't mean any derived classes have.
    /// </remarks>
    [UtilityTypeMarker]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public class MovedAttribute : Attribute
    {
        public string Message { get; set; }


        public MovedAttribute(
            string message)
        {
            this.Message = message;
        }
    }
}
