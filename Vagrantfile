Vagrant.configure("2") do |config|
    config.vm.box = "gusztavvargadr/docker-linux"
    config.vm.network "private_network", ip: "192.168.20.48"
    config.vm.synced_folder ".", "/vagrant"

    # For some reason DNS is not working properly in this VM.
    # Fix that by specifying an external DNS server instead on relying on the one of VirtualBox.
    config.vm.provision "shell", inline: <<-SHELL
        cat << EOF > /etc/systemd/resolved.conf
[Resolve]
DNS=8.8.8.8
EOF
        systemctl restart systemd-resolved
    SHELL
end
