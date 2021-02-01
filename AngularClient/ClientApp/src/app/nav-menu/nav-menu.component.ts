import { Component } from '@angular/core';
import { AuthService } from '../shared/services/auth.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

  public isUserAuthenticated: boolean = false;
  constructor(private _authService: AuthService) {}

  ngOnInit(): void {
    this._authService.loginChanged
    .subscribe(res => {
      this.isUserAuthenticated = res;
    })
  }
  public login = () => {
    this._authService.login();
  }
  public logout = () => {
    this._authService.logout();
  }

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
