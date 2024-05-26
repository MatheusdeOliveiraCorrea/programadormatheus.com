namespace agora.domain;

public interface IValidatedEntity
{
    void ThrowsIfInvalidData();
}
