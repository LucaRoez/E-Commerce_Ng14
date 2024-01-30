import { Component } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog'

@Component({
  selector: 'app-global-dialogs',
  templateUrl: './global-dialogs.component.html',
  styleUrl: './global-dialogs.component.css'
})
export class GlobalDialogsComponent {
  constructor(public dialogRef: MatDialogRef<GlobalDialogsComponent>) {}
}
