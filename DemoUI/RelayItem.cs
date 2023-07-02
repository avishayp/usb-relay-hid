using UsbRelayNet.RelayLib;

namespace DemoUI {
    public class RelayItem {

        public RelayItem(RelayInfo relayInfo) {
            RelayInfo = relayInfo;
        }

        public RelayInfo RelayInfo { get; private set; }

        public override string ToString() {
            return $"#{RelayInfo.Id} @{RelayInfo.HidInfo.Path}";
        }
    }
}
