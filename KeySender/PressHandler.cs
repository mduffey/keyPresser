using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeySender
{
    //https://stackoverflow.com/a/18291854
    public class PressHandler
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private bool _isRegistered;
        private readonly int _key;
        private readonly int _modifier;
        private readonly IntPtr _hWnd;

        public PressHandler(Keys key, Form form)
        {
            _key = (int) key;
            _modifier = 0;
            _hWnd = form.Handle;
            Id = Hash(); 
            Register();
        }

        public PressHandler(Keys key, Keys modifiers, Form form)
        {
            _key = (int)key;
            _modifier = TranslateModifier(modifiers);
            _hWnd = form.Handle;
            Id = Hash();
            Register();
        }

        ~PressHandler()
        {
            Unregister();
        }

        public int Id { get; }

        public override int GetHashCode() => Id;

        public bool Register()
        {
            if (!_isRegistered)
            {
                _isRegistered = RegisterHotKey(_hWnd, Id, _modifier, _key);
            }

            return _isRegistered;
        }

        public bool Unregister()
        {
            if (_isRegistered)
            {
                _isRegistered = UnregisterHotKey(_hWnd, Id);
            }

            return !_isRegistered;
        }

        private int Hash() => _key ^ _modifier ^ _hWnd.ToInt32();

        private int TranslateModifier(Keys modifierKeys)
        {
            var value = 0;
            if (modifierKeys.HasFlag(Keys.Alt))
            {
                value = 1;
            }

            if (modifierKeys.HasFlag(Keys.Control))
            {
                value += 2;
            }

            if (modifierKeys.HasFlag(Keys.Shift))
            {
                value += 4;
            }

            return value;
        }

    }
}