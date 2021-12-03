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
                },
                {
                    ""name"": ""spawn"",
                    ""type"": ""Button"",
                    ""id"": ""97475455-6cdb-4975-ac40-f010ac430e21"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""340d28cd-7d51-4498-a505-bd9ce6b73565"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""spawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9a325a7-9236-499b-8779-688547824020"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""spawn"",
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
                    ""name"": ""play"",
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
                    ""action"": ""play"",
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
        m_player_spawn = m_player.FindAction("spawn", throwIfNotFound: true);
        // GameManager
        m_GameManager = asset.FindActionMap("GameManager", throwIfNotFound: true);
        m_GameManager_pause = m_GameManager.FindAction("pause", throwIfNotFound: true);
        m_GameManager_play = m_GameManager.FindAction("play", throwIfNotFound: true);
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
    private readonly InputAction m_player_spawn;
    public struct PlayerActions
    {
        private @Controllers m_Wrapper;
        public PlayerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player_move;
        public InputAction @shoot => m_Wrapper.m_player_shoot;
        public InputAction @spawn => m_Wrapper.m_player_spawn;
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
                @spawn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawn;
                @spawn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawn;
                @spawn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpawn;
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
                @spawn.started += instance.OnSpawn;
                @spawn.performed += instance.OnSpawn;
                @spawn.canceled += instance.OnSpawn;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);

    // GameManager
    private readonly InputActionMap m_GameManager;
    private IGameManagerActions m_GameManagerActionsCallbackInterface;
    private readonly InputAction m_GameManager_pause;
    private readonly InputAction m_GameManager_play;
    public struct GameManagerActions
    {
        private @Controllers m_Wrapper;
        public GameManagerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @pause => m_Wrapper.m_GameManager_pause;
        public InputAction @play => m_Wrapper.m_GameManager_play;
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
                @play.started -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnPlay;
                @play.performed -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnPlay;
                @play.canceled -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnPlay;
            }
            m_Wrapper.m_GameManagerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
                @play.started += instance.OnPlay;
                @play.performed += instance.OnPlay;
                @play.canceled += instance.OnPlay;
            }
        }
    }
    public GameManagerActions @GameManager => new GameManagerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnSpawn(InputAction.CallbackContext context);
    }
    public interface IGameManagerActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnPlay(InputAction.CallbackContext context);
    }
}
