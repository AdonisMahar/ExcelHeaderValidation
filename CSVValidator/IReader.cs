namespace CSVValidator;

internal interface IReader
{
    ValidatorConfiguration Read(string content);
}
