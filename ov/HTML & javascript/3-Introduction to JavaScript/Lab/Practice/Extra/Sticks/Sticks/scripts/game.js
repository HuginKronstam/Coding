var divSec = document.getElementById("sticks");
var spanElm = document.getElementById("message");
var divBtn = document.getElementById("button");

var selFS = document.getElementById("selction_fs");
var radios = document.getElementsByName('oppent_grp');

var selOpponent = null;
var inTurn = -1; // 0 = Human 1 = Computer;

var startComp = document.getElementById("start_computer");

var sticksRemaining = 15;

var last_remainig = 15;

// Player Definitions <begin>
function StupidPlayer() {
    this.radioBtn = document.getElementById("stupidRB");
    this.wins = 0;
    this.losses = 0;
    this.makeMove = function (remaining) {
        return 1;
    };

    this.gameOver = function (youWon) {
        if (youWon) {
            this.wins++;
        } else {
            this.losses++;
        }
        this.radioBtn.textContent = "Stupid player " + this.wins + " - " + this.losses;
    };
}

function RandomPlayer() {
    this.radioBtn = document.getElementById("randomRB");
    this.wins = 0;
    this.losses = 0;
    this.makeMove = function (remaining) {
        return Math.floor(Math.random() * Math.min(3, remaining)) + 1;
    };

    this.gameOver = function (youWon) {
        if (youWon) {
            this.wins++;
        } else {
            this.losses++;
        }
        this.radioBtn.textContent = "Random player " + this.wins + " - " + this.losses;
    };
}

function SmartPlayer() {
    this.radioBtn = document.getElementById("smartRB");
    this.wins = 0;
    this.losses = 0;
    this.makeMove = function (remaining) {
        var tmpMove = ((sticksRemaining % 4) == 0 ? 4 : (sticksRemaining % 4)) - 1;

        if (tmpMove > 0) {
            return tmpMove;
        } else {
            return 1;
        }
    };


    this.gameOver = function (youWon) {
        if (youWon) {
            this.wins++;
        } else {
            this.losses++;
        }
        this.radioBtn.textContent = "Smart player " + this.wins + " - " + this.losses;
    };
}

function AIPlayer() {
    this.wins = 0;
    this.losses = 0;

    this.radioBtn = document.getElementById("aiRB");
    this.brain = [
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0],
        [0, 0, 0]
    ];
    this.oppentMove = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
    this.aiMove = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
    this.lastRemaining = 15;
    this.makeMove = function (remaining) {
        if (remaining < 15) {
            // oppent has made move, update oppents move
            this.oppentMove[this.lastRemaining - 1] = this.lastRemaining - remaining;
        }


        var bestScore = Math.max(this.brain[remaining - 1][0], this.brain[remaining - 1][1], this.brain[remaining - 1][2]);

        var match = -1;
        var foundDbl = false;
        for (var i = 0; i < 3; i++) {
            if (this.brain[remaining - 1][i] == bestScore && match != -1) {
                foundDbl = true;
                break;
            } else if (this.brain[remaining - 1][i] == bestScore) {
                match = i;
            }
        }

        var move = foundDbl ? Math.floor(Math.random() * Math.min(3, remaining)) + 1 : match + 1;

        this.aiMove[remaining - 1] = move;
        this.lastRemaining = remaining - move;

        return move;
    };

    this.gameOver = function (youWon) {
        var expPtn = youWon ? 1 : -1;

        for (var i = 0; i < 15; i++) {
            if (this.aiMove[i] > 0) {
                this.brain[i][this.aiMove[i] - 1] += expPtn;
            }
            if (this.oppentMove[i] > 0) {
                this.brain[i][this.oppentMove[i] - 1] -= expPtn;

            }
        }

        this.oppentMove = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        this.aiMove = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        this.lastRemaining = 15;

        if (youWon) {
            this.wins++;
        } else {
            this.losses++;
        }
        this.radioBtn.textContent = "AI player " + this.wins + " - " + this.losses;
    };
}
// Player Definitions <end>

var stupidPlayer = new StupidPlayer();
stupidPlayer.radioBtn = document.getElementById("stupidRB");
var randomPlayer = new RandomPlayer();
randomPlayer.radioBtn = document.getElementById("randomRB");
var smartPlayer = new SmartPlayer();
smartPlayer.radioBtn = document.getElementById("smartRB");
var aiPlayer = new AIPlayer();
aiPlayer.radioBtn = document.getElementById("aiRB");

function setOppentType() {
    for (var i = 0, length = radios.length; i < length; i++) {
        if (radios[i].checked) {
            switch (radios[i].value) {
                case "0":
                    selOpponent = stupidPlayer;
                    break;
                case "1":
                    selOpponent = randomPlayer;
                    break;
                case "2":
                    selOpponent = smartPlayer;
                    break;
                case "3":
                    selOpponent = aiPlayer;
                    break;
            }
        }
    }
}

function mouseOverStick(elm) {
    spanElm.textContent = "Mouse over stick " + elm.attributes["value"].value;
}

function mouseClick(elm) {
    if (selOpponent == null) {
        selFS.setAttribute("disabled", "true");
        setOppentType();
    }
    if (inTurn < 0) {
        inTurn = 0;
    }

    if (Number(elm.attributes["value"].value) >= sticksRemaining - 3) {
        for (i = Number(elm.attributes["value"].value); i < sticksRemaining; i++) {
            imgElm = document.getElementById("stick_" + i);
            imgElm.setAttribute("src", "content/match-stick-drawing-x.jpg");
        }
        sticksRemaining = Number(elm.attributes["value"].value);

        spanElm.textContent = sticksRemaining + " sticks remaining, make your pick!";
        if (sticksRemaining == 0) {
            if (inTurn == 1) {
                selOpponent.gameOver(false);
            } else {
                selOpponent.gameOver(true);
            }
            newGameBtn = document.createElement("input");
            newGameBtn.setAttribute("type", "button");
            newGameBtn.setAttribute("onclick", "newGame()");
            newGameBtn.value = "New Game";
            divBtn.appendChild(newGameBtn);
        } else {
            if (inTurn == 0) {
                divSec.setAttribute("disabled", "true");
                inTurn = 1;
                computerMakeMove();
                divSec.removeAttribute("disabled");
            } else {
                inTurn = 0;
            }
        }
    }
}

function newGame() {
    sticksRemaining = 15;
    inTurn = -1;
    selOpponent = null;
    for (i = 0; i < sticksRemaining; i++) {
        stick = divSec.children[i];
        stick.setAttribute("src", "content/match-stick-drawing.jpg");
    }
    spanElm.textContent = sticksRemaining + " sticks remaining, make your pick!";
    divBtn.removeChild(divBtn.children[0]);
    selFS.removeAttribute("disabled");
}

function start_comp() {

    selFS.setAttribute("disabled", "true");
    inTurn = 1;

    if (selOpponent == null) {
        setOppentType();
    }

    computerMakeMove();
}

function computerMakeMove() {
    mouseClick(divSec.children[sticksRemaining - selOpponent.makeMove(sticksRemaining)]);
}

for (i = 0; i < sticksRemaining; i++) {
    imgElm = document.createElement("img");
    imgElm.setAttribute("src", "content/match-stick-drawing.jpg");
    imgElm.setAttribute("id", "stick_" + i);
    imgElm.setAttribute("value", String(i));

    imgElm.setAttribute("onmouseover", "mouseOverStick(this)");
    imgElm.setAttribute("onclick", "mouseClick(this)");
    divSec.appendChild(imgElm);


}

startComp.setAttribute("onclick", "start_comp()");

spanElm.textContent = sticksRemaining + " sticks remaining, make your pick!";
