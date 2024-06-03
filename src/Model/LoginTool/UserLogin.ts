export class UserLogin {
    private _userName:string|undefined = undefined;
    private _password:string|undefined = undefined;

    public set userName(value:string){
        this._userName=value;
    }
    
    public get userName() : string {
        return this._userName!;
    }
    
    
    public set password(v : string) {
        this._password = v;
    }

    
    public get password() : string {
        return this._password!;
    }
    
    /** This function do can check to properties or fields validation control*/
    public isValid():boolean{
        if(this._userName === undefined || this._password === undefined)
            return false;
        else if(this._userName.trim() === null || this._password.trim() === null)
            return false
        else if(this._userName.trim().length<3 || this._password.trim().length<3)
            return false;
        else
            return true;
    }
}
