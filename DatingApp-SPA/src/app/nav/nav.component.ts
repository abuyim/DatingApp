import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {}
  constructor(private authService:AuthService) { }

  ngOnInit(): void {
  }

  login(){
    console.log("Login cliscked");
    this.authService.login(this.model).subscribe((res:any) => {
      console.log("Successfully Logged in");
      console.log(res)
    },
    (error:any)=>{
      console.log("Error Occured ");
      console.log(error);
    });
  }
  loggedIn(){
    const token = localStorage.getItem('token');
    return !!token;
  }

  logout(){
    localStorage.removeItem('token');
    console.log("Logout successfully");
  }

}
