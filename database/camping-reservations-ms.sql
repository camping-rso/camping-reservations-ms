CREATE TABLE vrsta_kampiranja (
  vrsta_kampiranja_id SERIAL PRIMARY KEY NOT NULL,
  naziv VARCHAR(45)
);

CREATE TABLE status_rezervacije (
  status_rezervacije_id SERIAL PRIMARY KEY NOT NULL,
  naziv VARCHAR(45)
);

CREATE TABLE rezervacije (
  rezervacija_id SERIAL PRIMARY KEY NOT NULL,
  trajanje_od timestamp(0),
  trajanje_do timestamp(0),
  uporabnik INT NOT NULL,
  avtokamp INT NOT NULL,
  kampirno_mesto INT NOT NULL,
  vrsta_kampiranja INT NOT NULL,
  status_rezervacije INT NOT NULL
);

ALTER TABLE rezervacije ADD FOREIGN KEY (vrsta_kampiranja) REFERENCES vrsta_kampiranja (vrsta_kampiranja_id) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE rezervacije ADD FOREIGN KEY (status_rezervacije) REFERENCES status_rezervacije (status_rezervacije_id) ON DELETE NO ACTION ON UPDATE NO ACTION;

CREATE INDEX fk_rezervacije_vrsta_kampiranja_idx ON rezervacije (vrsta_kampiranja);

CREATE INDEX fk_rezervacije_status_rezervacije_idx ON rezervacije (status_rezervacije);
