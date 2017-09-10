import 'whatwg-fetch';
import 'jquery';
import { HttpClient, json } from 'aurelia-fetch-client';
import { inject } from 'aurelia-framework';

let http = new HttpClient();

export interface Application {
    appName: string;
    appFolder: string;
    pool: string;
    url: string;
}

export interface ApplicationPool {
    appName: string;
    checked32Bit: boolean;
    enableRapidFailure: boolean;
    checkRapidFire: boolean;
    runTimeVersion: string;
    pipelineMode: string;
}

@inject(HttpClient)
export class CreateIISWeb {
    
    public http: HttpClient = new HttpClient();
    public disabled: boolean = true;
    public selectedValue: string = '';
    public selectedValue2: string = '';

    public appPool: ApplicationPool;
    public app: Application;

    constructor(http: any) {
        this.http = http;
    }

    SaveStep1() {
        
        console.log(this.appPool);
        console.log(json(this.appPool));
        this.http.fetch("api/CreateAppPool/Create", {
            method: "POST",
            body: json(this.appPool)
        })
            .then(response => {
                console.log(response);
            })
            .then(data => {
                console.log(data);
            })
    }

    changeRapidFire() {
        if (this.appPool.checkRapidFire) {
            this.appPool.enableRapidFailure = false;
        } else {
            this.appPool.enableRapidFailure = true;
        }
    }

    changeRunTimeValue() {
        if (this.appPool.runTimeVersion == "2") {
            this.appPool.runTimeVersion = "2.0";
        } else if (this.appPool.runTimeVersion == "4") {
            this.appPool.runTimeVersion = "4.0"
        }
    }

    LogData(obj:any) {
        console.log(obj);
    }

    SaveStep2() {
        console.log(this.appPool);
        console.log(json(this.appPool));
        this.http.fetch("api/CreateAppPool/Create", {
            method: "POST",
            body: json(this.appPool)
        })
            .then(response => response.json())
            .then(data => {
                console.log(data);
            })
    }
    

}



