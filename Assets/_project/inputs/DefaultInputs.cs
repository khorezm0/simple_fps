// GENERATED AUTOMATICALLY FROM 'Assets/_project/inputs/DefaultInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DefaultInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultInputs"",
    ""maps"": [
        {
            ""name"": ""MainMap"",
            ""id"": ""2b3add33-5ba7-4448-ab92-557488fc53f4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d9f719de-bbfb-4894-a5d2-cf99ff7ffa76"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""7b1b87bb-2a64-412a-9ccb-002a7ec72b82"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Value"",
                    ""id"": ""534cbddf-76fe-4bbc-8f2f-2f5fb41742da"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Value"",
                    ""id"": ""8a745a48-6efa-495e-9c0a-cb8b1594feb2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Value"",
                    ""id"": ""9ca5fb7f-4405-4ba7-aff3-83494688a0f9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""61d7a0ee-1a71-4421-a6cd-c6f209e0ece6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Strafe"",
                    ""type"": ""Value"",
                    ""id"": ""da1814fc-9343-46a0-86f3-63f1804423e6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0ba7f90a-bd01-46da-878f-cf5312f72764"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""1257ade9-d89b-4438-a84c-aedba496d304"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""70fe6e5e-daad-4849-b020-c82b1d686510"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fb47212c-2d3d-4e5a-be1e-f6b69656cfca"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e3c53dac-c879-4126-8eef-c4026bda3449"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b14bd855-94cb-4d57-9077-98ea6482f7b4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""420a4a56-cc0a-4b38-8efe-637548b3a551"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""30d94de2-7928-4797-b9da-085cd4ae9a7f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d2f58d0b-cc06-4ed1-9776-6dcf625f071d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""88839e4d-e28c-44b3-ac9b-c86889c62fac"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7d0e08c8-6fc8-4e91-9baa-7e0f5131198e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""387aa537-327e-4cf3-843e-50b5cf745bb8"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20db0d24-1fea-4fda-814a-2321bb894325"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23fc18e8-ba38-4008-ba60-bfde1658a3e1"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""257269cc-0aec-4009-87d3-7242dae4bd5e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed936816-f539-413f-87d2-3d1566b37339"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6e279eb-0eb4-48bb-acf2-83bf156d854a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""667c23ac-3cc8-4398-b924-b97b7a5040e6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b181d5b-67c4-4f94-b437-63efac0cf86b"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc27b1de-4cbf-482a-b122-f4c13eda54cc"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77a8a94e-b603-4968-b52f-98365b12daad"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b28b6f6c-8c09-433d-8f4c-ffb17314790d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b789c4d-03b4-4e66-b025-c5b7c72f14c3"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a77c18b-212f-4bdd-9c1a-62827171f14d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MainMap
        m_MainMap = asset.FindActionMap("MainMap", throwIfNotFound: true);
        m_MainMap_Move = m_MainMap.FindAction("Move", throwIfNotFound: true);
        m_MainMap_Look = m_MainMap.FindAction("Look", throwIfNotFound: true);
        m_MainMap_Fire = m_MainMap.FindAction("Fire", throwIfNotFound: true);
        m_MainMap_Interact = m_MainMap.FindAction("Interact", throwIfNotFound: true);
        m_MainMap_Reload = m_MainMap.FindAction("Reload", throwIfNotFound: true);
        m_MainMap_Jump = m_MainMap.FindAction("Jump", throwIfNotFound: true);
        m_MainMap_Strafe = m_MainMap.FindAction("Strafe", throwIfNotFound: true);
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

    // MainMap
    private readonly InputActionMap m_MainMap;
    private IMainMapActions m_MainMapActionsCallbackInterface;
    private readonly InputAction m_MainMap_Move;
    private readonly InputAction m_MainMap_Look;
    private readonly InputAction m_MainMap_Fire;
    private readonly InputAction m_MainMap_Interact;
    private readonly InputAction m_MainMap_Reload;
    private readonly InputAction m_MainMap_Jump;
    private readonly InputAction m_MainMap_Strafe;
    public struct MainMapActions
    {
        private @DefaultInputs m_Wrapper;
        public MainMapActions(@DefaultInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MainMap_Move;
        public InputAction @Look => m_Wrapper.m_MainMap_Look;
        public InputAction @Fire => m_Wrapper.m_MainMap_Fire;
        public InputAction @Interact => m_Wrapper.m_MainMap_Interact;
        public InputAction @Reload => m_Wrapper.m_MainMap_Reload;
        public InputAction @Jump => m_Wrapper.m_MainMap_Jump;
        public InputAction @Strafe => m_Wrapper.m_MainMap_Strafe;
        public InputActionMap Get() { return m_Wrapper.m_MainMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainMapActions set) { return set.Get(); }
        public void SetCallbacks(IMainMapActions instance)
        {
            if (m_Wrapper.m_MainMapActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MainMapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MainMapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MainMapActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_MainMapActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_MainMapActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_MainMapActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_MainMapActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_MainMapActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_MainMapActionsCallbackInterface.OnFire;
                @Interact.started -= m_Wrapper.m_MainMapActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_MainMapActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_MainMapActionsCallbackInterface.OnInteract;
                @Reload.started -= m_Wrapper.m_MainMapActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_MainMapActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_MainMapActionsCallbackInterface.OnReload;
                @Jump.started -= m_Wrapper.m_MainMapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MainMapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MainMapActionsCallbackInterface.OnJump;
                @Strafe.started -= m_Wrapper.m_MainMapActionsCallbackInterface.OnStrafe;
                @Strafe.performed -= m_Wrapper.m_MainMapActionsCallbackInterface.OnStrafe;
                @Strafe.canceled -= m_Wrapper.m_MainMapActionsCallbackInterface.OnStrafe;
            }
            m_Wrapper.m_MainMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Strafe.started += instance.OnStrafe;
                @Strafe.performed += instance.OnStrafe;
                @Strafe.canceled += instance.OnStrafe;
            }
        }
    }
    public MainMapActions @MainMap => new MainMapActions(this);
    public interface IMainMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnStrafe(InputAction.CallbackContext context);
    }
}
