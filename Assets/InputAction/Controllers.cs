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
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""a75d895c-c06e-4245-b224-e93cb7754063"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""resume/play"",
                    ""type"": ""Button"",
                    ""id"": ""9aeaa1a4-0e8d-4d79-ae2a-3b6b2133a93a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""stopMusic"",
                    ""type"": ""Button"",
                    ""id"": ""f80c4f7f-c632-4ee6-a6d7-d5188f4fb133"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""playMusic"",
                    ""type"": ""Button"",
                    ""id"": ""982af7ac-2c26-4247-9d6a-bb2fa01d8e45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""tripleShoot"",
                    ""type"": ""Button"",
                    ""id"": ""84fd978c-fdf7-44b7-bcf7-5310e94ff96a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0da01cc4-a52a-49ba-9b5c-fc239555c27c"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4632602e-ddbb-4668-807e-0172c2aff959"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
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
                    ""groups"": ""Keyboard"",
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
                    ""groups"": ""Keyboard"",
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
                    ""groups"": ""Keyboard"",
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
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0f43f97a-7715-4301-a9be-75de17ca188a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22fcb377-4eb7-4f09-8796-c5c41959db5c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e9447d2-9ae3-4142-a034-dce8870a9349"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""976aeddd-7448-460a-b1c7-956be8f7c4e0"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""resume/play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3be0eb3d-3942-4381-b9d3-d9b0e754d90d"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""resume/play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c650273d-b315-48e1-a94b-b075f32fb4dc"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""stopMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""888fe1d5-48fc-4fd5-9ecf-03040468c25b"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""stopMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d543e532-1a39-447c-81c9-2afa000c214b"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""playMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2897965d-9f2e-459b-9672-8969bccaf4ab"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""playMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""344e68a4-a6bb-46fd-81ba-7b38f54dadbb"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""tripleShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""439c49f5-7cec-4b51-af9d-b9d184a04dc6"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""tripleShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_move = m_player.FindAction("move", throwIfNotFound: true);
        m_player_shoot = m_player.FindAction("shoot", throwIfNotFound: true);
        m_player_pause = m_player.FindAction("pause", throwIfNotFound: true);
        m_player_resumeplay = m_player.FindAction("resume/play", throwIfNotFound: true);
        m_player_stopMusic = m_player.FindAction("stopMusic", throwIfNotFound: true);
        m_player_playMusic = m_player.FindAction("playMusic", throwIfNotFound: true);
        m_player_tripleShoot = m_player.FindAction("tripleShoot", throwIfNotFound: true);
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
    private readonly InputAction m_player_pause;
    private readonly InputAction m_player_resumeplay;
    private readonly InputAction m_player_stopMusic;
    private readonly InputAction m_player_playMusic;
    private readonly InputAction m_player_tripleShoot;
    public struct PlayerActions
    {
        private @Controllers m_Wrapper;
        public PlayerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player_move;
        public InputAction @shoot => m_Wrapper.m_player_shoot;
        public InputAction @pause => m_Wrapper.m_player_pause;
        public InputAction @resumeplay => m_Wrapper.m_player_resumeplay;
        public InputAction @stopMusic => m_Wrapper.m_player_stopMusic;
        public InputAction @playMusic => m_Wrapper.m_player_playMusic;
        public InputAction @tripleShoot => m_Wrapper.m_player_tripleShoot;
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
                @pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @resumeplay.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResumeplay;
                @resumeplay.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResumeplay;
                @resumeplay.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResumeplay;
                @stopMusic.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopMusic;
                @stopMusic.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopMusic;
                @stopMusic.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopMusic;
                @playMusic.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayMusic;
                @playMusic.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayMusic;
                @playMusic.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayMusic;
                @tripleShoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTripleShoot;
                @tripleShoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTripleShoot;
                @tripleShoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTripleShoot;
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
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
                @resumeplay.started += instance.OnResumeplay;
                @resumeplay.performed += instance.OnResumeplay;
                @resumeplay.canceled += instance.OnResumeplay;
                @stopMusic.started += instance.OnStopMusic;
                @stopMusic.performed += instance.OnStopMusic;
                @stopMusic.canceled += instance.OnStopMusic;
                @playMusic.started += instance.OnPlayMusic;
                @playMusic.performed += instance.OnPlayMusic;
                @playMusic.canceled += instance.OnPlayMusic;
                @tripleShoot.started += instance.OnTripleShoot;
                @tripleShoot.performed += instance.OnTripleShoot;
                @tripleShoot.canceled += instance.OnTripleShoot;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnResumeplay(InputAction.CallbackContext context);
        void OnStopMusic(InputAction.CallbackContext context);
        void OnPlayMusic(InputAction.CallbackContext context);
        void OnTripleShoot(InputAction.CallbackContext context);
    }
}
