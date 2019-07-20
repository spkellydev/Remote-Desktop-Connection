# ArdiFin (Automated Remote Desktop Installations For Insulated Networks)

The goal of this project to create a single source of truth for remote desktop installations across multiple servers. The preferred approach today is to create long-winded procedures which someone must follow to the letter, this method is prone to error and causes installations to drag on. Ardi Fin is a WIP toy project to remove the pain from these insallations and automate installations across multiple servers.

### What's Needed?

Everything, right now there is little more than a way to generate RDP files. The project right now is being considered to be arcitected through windows services, communicating over WCF internally and over TCP between remove instances.