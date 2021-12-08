// GENERATED AUTOMATICALLY FROM 'Assets/InputAction/Controllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controllers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controllers"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""2a100861-52b0-43b5-994e-f87abb5788d3"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0e57af8b-35c8-4d7e-9dc5-7c00aa27471d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c45e9048-25a6-4113-b638-e17f317509e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ad9611e7-36ad-443e-bf5a-99c37786c2cd"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e25bf156-e17f-47d8-b4e4-0e59185845f8"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0da01cc4-a52a-49ba-9b5c-fc239555c27c"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9ca189db-cee6-4f26-a6b0-4b4af3e25ec4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""41b80a52-1d1a-4421-9611-1c710eedec96"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0d22eecc-e38c-4727-bc98-dcb91d60cd2c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bf1dc8f3-cc0f-416c-9258-f60d0559cc78"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""69f1b443-c617-4934-9dab-5137c6fe991d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e9d38737-58f1-4f57-827b-cf8d3a140448"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameManager"",
            ""id"": ""f9c72090-6df3-4b04-ad90-be0c36224578"",
            ""actions"": [
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""642b0f26-bb2f-4ae7-a4b1-e4dc99ab73d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""resume/play"",
                    ""type"": ""Button"",
                    ""id"": ""74cf2ad1-8e24-4dc4-8300-ce3e9fdda2f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4cc4089f-5668-4b1e-9679-9b2671adea8f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa1e9f8f-cc20-4645-9cbd-8a5984b47728"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""resume/play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""audio"",
            ""id"": ""697baa78-8824-492d-89bc-2fad87984119"",
            ""actions"": [
                {
                    ""name"": ""play"",
                    ""type"": ""Button"",
                    ""id"": ""80336bc0-8a38-4849-ba7d-afbd3ddc3ba9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""stop"",
                    ""type"": ""Button"",
                    ""id"": ""1f9624db-e907-4b5b-a165-8ef327ff1994"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""578b3300-fd61-47e4-9d51-e981be21faad"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87a15f6b-82bd-4359-a462-fb8c59f00a66"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""stop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_move = m_player.FindAction("move", throwIfNotFound: true);
        m_player_shoot = m_player.FindAction("shoot", throwIfNotFound: true);
        // GameManager
        m_GameManager = asset.FindActionMap("GameManager", throwIfNotFound: true);
        m_GameManager_pause = m_GameManager.FindAction("pause", throwIfNotFound: true);
        m_GameManager_resumeplay = m_GameManager.FindAction("resume/play", throwIfNotFound: true);
        // audio
        m_audio = asset.FindActionMap("audio", throwIfNotFound: true);
        m_audio_play = m_audio.FindAction("play", throwIfNotFound: true);
        m_audio_stop = m_audio.FindAction("stop", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_move;
    private readonly InputAction m_player_shoot;
    public struct PlayerActions
    {
        private @Controllers m_Wrapper;
        public PlayerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player_move;
        public InputAction @shoot => m_Wrapper.m_player_shoot;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @shoot.started += instance.OnShoot;
                @shoot.performed += instance.OnShoot;
                @shoot.canceled += instance.OnShoot;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);

    // GameManager
    private readonly InputActionMap m_GameManager;
    private IGameManagerActions m_GameManagerActionsCallbackInterface;
    private readonly InputAction m_GameManager_pause;
    private readonly InputAction m_GameManager_resumeplay;
    public struct GameManagerActions
    {
        private @Controllers m_Wrapper;
        public GameManagerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @pause => m_Wrapper.m_GameManager_pause;
        public InputAction @resumeplay => m_Wrapper.m_GameManager_resumeplay;
        public InputActionMap Get() { return m_Wrapper.m_GameManager; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameManagerActions set) { return set.Get(); }
        public void SetCallbacks(IGameManagerActions instance)
        {
            if (m_Wrapper.m_GameManagerActionsCallbackInterface != null)
            {
                @pause.started -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnPause;
                @pause.performed -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnPause;
                @pause.canceled -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnPause;
                @resumeplay.started -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnResumeplay;
                @resumeplay.performed -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnResumeplay;
                @resumeplay.canceled -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnResumeplay;
            }
            m_Wrapper.m_GameManagerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
                @resumeplay.started += instance.OnResumeplay;
                @resumeplay.performed += instance.OnResumeplay;
                @resumeplay.canceled += instance.OnResumeplay;
            }
        }
    }
    public GameManagerActions @GameManager => new GameManagerActions(this);

    // audio
    private readonly InputActionMap m_audio;
    private IAudioActions m_AudioActionsCallbackInterface;
    private readonly InputAction m_audio_play;
    private readonly InputAction m_audio_stop;
    public struct AudioActions
    {
        private @Controllers m_Wrapper;
        public AudioActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @play => m_Wrapper.m_audio_play;
        public InputAction @stop => m_Wrapper.m_audio_stop;
        public InputActionMap Get() { return m_Wrapper.m_audio; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AudioActions set) { return set.Get(); }
        public void SetCallbacks(IAudioActions instance)
        {
            if (m_Wrapper.m_AudioActionsCallbackInterface != null)
            {
                @play.started -= m_Wrapper.m_AudioActionsCallbackInterface.OnPlay;
                @play.performed -= m_Wrapper.m_AudioActionsCallbackInterface.OnPlay;
                @play.canceled -= m_Wrapper.m_AudioActionsCallbackInterface.OnPlay;
                @stop.started -= m_Wrapper.m_AudioActionsCallbackInterface.OnStop;
                @stop.performed -= m_Wrapper.m_AudioActionsCallbackInterface.OnStop;
                @stop.canceled -= m_Wrapper.m_AudioActionsCallbackInterface.OnStop;
            }
            m_Wrapper.m_AudioActionsCallbackInterface = instance;
            if (instance != null)
            {
                @play.started += instance.OnPlay;
                @play.performed += instance.OnPlay;
                @play.canceled += instance.OnPlay;
                @stop.started += instance.OnStop;
                @stop.performed += instance.OnStop;
                @stop.canceled += instance.OnStop;
            }
        }
    }
    public AudioActions @audio => new AudioActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IGameManagerActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnResumeplay(InputAction.CallbackContext context);
    }
    public interface IAudioActions
    {
        void OnPlay(InputAction.CallbackContext context);
        void OnStop(InputAction.CallbackContext context);
    }
}
