import 'whatwg-fetch';
import { HttpClient, json } from 'aurelia-fetch-client';
import { inject } from 'aurelia-framework';

let http = new HttpClient();

@inject(HttpClient)
export class CreateIISWeb {
    public appName: string;
    public checked32Bit: boolean;
    public enableRapidFailure: boolean;
    public checkRapidFire: boolean;
    public runTimeVersion: string;
    public pipelineMode: string;
    public http: HttpClient = new HttpClient();

    constructor(http: any) {
        this.http = http;
    }

    SaveStep1() {
        let obj = {
            applicationName : this.appName,
            Enable32Bit: this.checked32Bit,
            mode: this.pipelineMode,
            runTimeVersion: this.runTimeVersion,
            enableRapidFailure: this.enableRapidFailure 
        };
        console.log(obj);
        console.log(json(obj));
        this.http.fetch("api/CreateAppPool/Create", {
            method: "POST",
            body: json(obj)
        })
            .then(response => {
                console.log(response);
            })
            .then(data => {
                console.log(data);
            })
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

