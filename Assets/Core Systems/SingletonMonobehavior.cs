using UnityEngine;

/// <summary>
/// Base class for MonoBehaviours that want to auto-register as a singleton to the dependency container.
/// </summary>
public abstract class SingletonMonobehavior<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    protected virtual void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogWarning($"{typeof(T).Name} already exists, destroying duplicate");
            Destroy(gameObject);
            return;
        }

        Instance = this as T;
        DependencyContainer.Instance.Register<T>(Instance);
    }

    protected virtual void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }
}
