Restaurer les packets nugets :
 - nlog
 - newtonsoft json
Adapter le chemin des logs au niveau de NLog.config : (par défaut : d:/logs/ ) 
Adapter le chemin du profil de publication "Distrib" : (par défaut : d:/Distrib)
Créer l'application IIS qui pointera le répertoire de la distrib idéalement accessible avec l'url  http://localhost/Services/LemonWayService.asmx  sinon adapter 
                                                                                                            les références du projet client avec la nouvelle Url  