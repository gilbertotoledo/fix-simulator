using Acceptor;
using FixApplication;
using QuickFix;
using QuickFix.Transport;

namespace FixSimulatorDesktop.FixApplication
{
    public class FixApplicationManager
    {
        private IAcceptor _socketAcceptor = null;
        private IInitiator _socketInitiator = null;
        private readonly Action<string> _initiatorLoggerHandler;
        private readonly Action<string> _acceptorLoggerHandler;
        private readonly Action<QuickFix.Message> _onMessageHandler;

        public AcceptorFixApp AcceptorFixApp { get; private set; }
        public InitiatorFixApp InitiatorFixApp { get; private set; }

        public FixApplicationManager(Action<string> initiatorLoggerHandler, Action<string> acceptorLoggerHandler, Action<QuickFix.Message> onMessageHandler)
        {
            _initiatorLoggerHandler = initiatorLoggerHandler;
            _acceptorLoggerHandler = acceptorLoggerHandler;
            _onMessageHandler = onMessageHandler;
        }

        public bool StartAcceptor()
        {
            try
            {
                AcceptorFixApp = new AcceptorFixApp(_acceptorLoggerHandler, _onMessageHandler);
                var settings = new SessionSettings("FixConfig/Acceptor.cfg");
                var storeFactory = new FileStoreFactory(settings);
                var logFactory = new FileLogFactory(settings);
                _socketAcceptor = new ThreadedSocketAcceptor(AcceptorFixApp, storeFactory, settings, logFactory);

                _socketAcceptor.Start();
                return true;
            }
            catch (Exception ex)
            {
                _initiatorLoggerHandler.Invoke($"ERROR {ex}");
                return false;
            }
        }

        public void StopAcceptor()
        {
            _socketAcceptor?.Stop(true);
        }

        public bool StartInitiator()
        {
            try
            {
                InitiatorFixApp = new InitiatorFixApp(_initiatorLoggerHandler, _onMessageHandler);
                var settings = new SessionSettings("FixConfig/Initiator.cfg");
                var storeFactory = new FileStoreFactory(settings);
                var logFactory = new FileLogFactory(settings);
                _socketInitiator = new SocketInitiator(InitiatorFixApp, storeFactory, settings, logFactory);

                _socketInitiator.Start();
                return true;
            }
            catch(Exception ex)
            {
                _initiatorLoggerHandler.Invoke($"ERROR {ex}");
                return false;
            }
        }

        public void StopInitiator()
        {
            _socketInitiator?.Stop(true);
        }
    }
}
