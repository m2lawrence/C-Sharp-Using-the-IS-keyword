# C-Sharp-Using-the-IS-keyword
C# has the is keyword, it's used to do a comparison to see whether an object is of a certain type.


//--------------------
Using the as Keyword:

The as operator works similarly to a cast. The as keyword cast an object to a different
type. The type being cast to must be compatible with the original type. Remember, a cast
is simply a way to force a value to a different type. The format of as is as follows:
expression as DataType
Here, expression results in a reference type and DataType is a reference type. A similar
cast would take this form:
(DataType) expression
Although using the as keyword is similar to a cast, it is not the same. If you use a cast
and there is a problem—such as trying to cast a string as a number—an exception is
thrown.

With as, if there is an error in changing the expression to the DataType, the expression is
set to the value of null and converted to the DataType anyway. However, no exception is
thrown. This makes using the as keyword safer than doing a cast.
