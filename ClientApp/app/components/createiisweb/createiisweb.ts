import { HttpClient } from 'aurelia-fetch-client';
import { inject } from 'aurelia-framework';

@inject(HttpClient)
export class CreateIISWeb {
    public appName: string;
    public checked32Bit: boolean;
    public enableRapidFailure: boolean;
    public checkRapidFire: boolean;
    public runTimeVersion: string;
    public pipelineMode: string;
    constructor() {

    }

    changeRapidFire() {
        if (this.checkRapidFire) {
            this.enableRapidFailure = false;
        } else {
            this.enableRapidFailure = true;
        }
    }

    changeRunTimeValue() {
        if (this.runTimeVersion == "2") {
            this.runTimeVersion = "2.0";
        } else if (this.runTimeVersion == "4") {
            this.runTimeVersion = "4.0"
        }
    }

    sayHello() {
        alert("Werte der Variablen: \n" + "AppName: " + this.appName + "\n" + "PipeLine: " + this.pipelineMode + "\n" + "runTimeVersion: " + this.runTimeVersion + "\n" + "32Bit:" + this.checked32Bit + "\n" + "Schnelle Fehler: " + this.enableRapidFailure);
    }

}