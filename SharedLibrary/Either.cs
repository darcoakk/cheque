using System.Text.Json;
using System.Text.Json.Serialization;
using CalcResult = Either<decimal,string>;

[JsonConverter(typeof(CalcResultConverter<decimal,string>))]
public class Either<L, R>
{
    private readonly L left;
    private readonly R right;
    private readonly bool isLeft;

    public Either(L left)
    {
        this.left = left;
        this.right = default(R);
        this.isLeft = true;
    }

    public Either(R right)
    {
        this.right = right;
        this.left = default(L);
        this.isLeft = false;
    }

    public T Match<T>(Func<L, T> leftFunc, Func<R, T> rightFunc)
    {
        return isLeft ? leftFunc(left) : rightFunc(right);
    }
    public bool IsLeft => isLeft;
    public bool IsRight => !isLeft;

    public L Left => isLeft ? left : throw new InvalidOperationException("Attempted to retrieve Left value from a Right");
    public R Right => !isLeft ? right : throw new InvalidOperationException("Attempted to retrieve Right value from a Left");

    public static implicit operator Either<L, R>(L left) => new Either<L, R>(left);
    public static implicit operator Either<L, R>(R right) => new Either<L, R>(right);

    public JsonElement ToJson()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        return isLeft ? JsonDocument.Parse(JsonSerializer.Serialize(left, options)).RootElement
                      : JsonDocument.Parse(JsonSerializer.Serialize(right, options)).RootElement;
    }

}
public class CalcResultConverter<L, R> : JsonConverter<Either<L, R>>
{
    public override Either<L, R> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, Either<L, R> value, JsonSerializerOptions options)
    {
        if (value.IsLeft)
        {
            JsonSerializer.Serialize(writer, value.Left, options);
        }
        else
        {
            JsonSerializer.Serialize(writer, value.Right, options);
        }
    }
}
