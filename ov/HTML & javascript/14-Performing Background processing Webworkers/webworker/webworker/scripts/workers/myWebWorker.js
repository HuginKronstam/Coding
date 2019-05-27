function messageHandler(event)
{
    var msg = event.data; //Input data must be JSON
    switch (msg.command)
    {
        case "DOWORK":
            self.postMessage("You did work, good boy " + msg.data);
            break;
        case "DOMOREWORK":
            self.postMessage("Doing more work  " + msg.data);
            break;
        case "FINISH":
            self.postMessage("Shutting down");
            self.close;
            break;
    }
}

self.addEventListener("message", messageHandler, false);
