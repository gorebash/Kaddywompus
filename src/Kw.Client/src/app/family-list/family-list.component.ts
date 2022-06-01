import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';
import { FormBuilder } from '@angular/forms';
import { tap } from 'rxjs';

@Component({
  selector: 'app-family-list',
  templateUrl: './family-list.component.html',
  styleUrls: ['./family-list.component.scss']
})
export class FamilyListComponent implements OnInit {

  family:Observable<Array<any> | null>;

  newMemberForm = this.fb.group({
    firstName: ['']
  });

  constructor(private http:HttpClient, private fb:FormBuilder) { 
    this.family = new Observable();
  }

  ngOnInit(): void {
    this.loadFamily();
  }

  addMember (): void {
    if (!this.newMemberForm.valid)
      return;

    this.http.post<Array<any>>(
      `${environment.apiUrl}/familymembers`, this.newMemberForm.value)
      .subscribe(f => this.loadFamily());
            
  }

  private loadFamily () {
    this.family = this.http.get<Array<any>>(`${environment.apiUrl}/familymembers`);
  }

}
