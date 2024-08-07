namespace agora.domain;

public interface IValidatedEntity
{
    void ThrowsIfInvalidData(bool creatingEntity = false);
}
