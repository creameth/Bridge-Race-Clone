//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/PlayerInputMaps.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputMaps : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputMaps()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputMaps"",
    ""maps"": [
        {
            ""name"": ""PlayerTouch"",
            ""id"": ""fb08f9ed-d6a6-4dc7-b5a4-2dfca5512c75"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2aa56102-949e-460c-9905-0c736c9cee37"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FirstTouch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3e90011a-1220-41c3-a4c5-1510d89d2b39"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchHolding"",
                    ""type"": ""Button"",
                    ""id"": ""c850efc4-be13-40d5-884d-ff5bb343e5aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""31d434e3-8b6b-4583-85a7-c13abba61a33"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d642ee4f-b221-46dd-8980-d69299bbec02"",
                    ""path"": ""<Touchscreen>/primaryTouch/startPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FirstTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afc82d68-a5d1-44d6-a33c-20fe5f0ab6e4"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchHolding"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""62497ea7-6870-43f2-87bc-890caa5829e9"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""48afc1de-c602-411c-9172-5d0b4fc453ad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""c4216aa4-69d5-47dc-a152-660b9f494291"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f6e04e05-2285-42fb-8177-42cb8714ba0b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a97b9cff-a616-4d1c-91d6-cfe0ee74777d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e8caf70d-d24a-479f-b1ba-b24af1e709d7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f4f58757-56ba-4cd6-bb17-6995b7962c0d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""769e4dd0-5ab6-4cd8-86aa-e1bce2dc6d42"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""31545ea8-52b7-4b6b-a12c-5bbb4bb6c447"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerTouch
        m_PlayerTouch = asset.FindActionMap("PlayerTouch", throwIfNotFound: true);
        m_PlayerTouch_Move = m_PlayerTouch.FindAction("Move", throwIfNotFound: true);
        m_PlayerTouch_FirstTouch = m_PlayerTouch.FindAction("FirstTouch", throwIfNotFound: true);
        m_PlayerTouch_TouchHolding = m_PlayerTouch.FindAction("TouchHolding", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerTouch
    private readonly InputActionMap m_PlayerTouch;
    private IPlayerTouchActions m_PlayerTouchActionsCallbackInterface;
    private readonly InputAction m_PlayerTouch_Move;
    private readonly InputAction m_PlayerTouch_FirstTouch;
    private readonly InputAction m_PlayerTouch_TouchHolding;
    public struct PlayerTouchActions
    {
        private @PlayerInputMaps m_Wrapper;
        public PlayerTouchActions(@PlayerInputMaps wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerTouch_Move;
        public InputAction @FirstTouch => m_Wrapper.m_PlayerTouch_FirstTouch;
        public InputAction @TouchHolding => m_Wrapper.m_PlayerTouch_TouchHolding;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTouch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTouchActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTouchActions instance)
        {
            if (m_Wrapper.m_PlayerTouchActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerTouchActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerTouchActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerTouchActionsCallbackInterface.OnMove;
                @FirstTouch.started -= m_Wrapper.m_PlayerTouchActionsCallbackInterface.OnFirstTouch;
                @FirstTouch.performed -= m_Wrapper.m_PlayerTouchActionsCallbackInterface.OnFirstTouch;
                @FirstTouch.canceled -= m_Wrapper.m_PlayerTouchActionsCallbackInterface.OnFirstTouch;
                @TouchHolding.started -= m_Wrapper.m_PlayerTouchActionsCallbackInterface.OnTouchHolding;
                @TouchHolding.performed -= m_Wrapper.m_PlayerTouchActionsCallbackInterface.OnTouchHolding;
                @TouchHolding.canceled -= m_Wrapper.m_PlayerTouchActionsCallbackInterface.OnTouchHolding;
            }
            m_Wrapper.m_PlayerTouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @FirstTouch.started += instance.OnFirstTouch;
                @FirstTouch.performed += instance.OnFirstTouch;
                @FirstTouch.canceled += instance.OnFirstTouch;
                @TouchHolding.started += instance.OnTouchHolding;
                @TouchHolding.performed += instance.OnTouchHolding;
                @TouchHolding.canceled += instance.OnTouchHolding;
            }
        }
    }
    public PlayerTouchActions @PlayerTouch => new PlayerTouchActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Look;
    public struct PlayerActions
    {
        private @PlayerInputMaps m_Wrapper;
        public PlayerActions(@PlayerInputMaps wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerTouchActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnFirstTouch(InputAction.CallbackContext context);
        void OnTouchHolding(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
